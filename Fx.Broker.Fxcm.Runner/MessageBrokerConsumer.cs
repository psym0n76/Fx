using System;
using EasyNetQ;
using Fx.Domain.Message.Interface;
using Fx.Domain.Message.Request;
using Fx.MessageBus.Publishers;

namespace Fx.Broker.Fxcm.Runner
{
    public class MessageBrokerConsumer
    {
        private readonly SampleParams _mSampleParams;
        private readonly IBrokerSession _mBrokerSession;
        private Session _brokerSession;
        private readonly INetQPublish _netQPublish;

        public MessageBrokerConsumer(SampleParams sampleParams, IBrokerSession brokerSession, INetQPublish netQPublish)
        {
            _mSampleParams = sampleParams;
            _mBrokerSession = brokerSession;
            _netQPublish = netQPublish;
        }

        private const string Host = "host=localhost";

        public void Run()
        {
            try
            {
                _brokerSession = _mBrokerSession.GetSession(_mSampleParams.AccessToken, _mSampleParams.Url);
                _brokerSession.Connect();

                Console.WriteLine("Connected");

                SubscribeCandleMessage();

                Console.WriteLine("Disconnected");
                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
        }

        private void SubscribeCandleMessage()
        {
            using (var bus = RabbitHutch.CreateBus(Host))
            {
                bus.Subscribe<RequestCandle>("Candle", @interface =>
                {
                    if (@interface is RequestCandle candle)
                    {
                        HandleTextMessage(candle);
                    }
                });
                Console.WriteLine("Listening for Candle messages. Hit <return> to quit.");
                Console.ReadLine();
            }
        }

        private void HandleTextMessage(IRequest message)
        {
            if (message == null) return;

            var process = BrokerProcessFactory.Get(message.Text);

            // return a message of some kind
            process.Run(_brokerSession, _mSampleParams);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Got message: {0}", message.Text);
            Console.ResetColor();
        }
    }
}