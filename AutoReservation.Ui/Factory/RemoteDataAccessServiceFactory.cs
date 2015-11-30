using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoReservation.Common.Interfaces;
using System.ServiceModel;

namespace AutoReservation.Ui.Factory
{
    class RemoteDataAccessServiceFactory : IServiceFactory
    {
        private IAutoReservationService target;

        public IAutoReservationService GetService()
        {
            if (target == null)
            {
                ChannelFactory<IAutoReservationService> channelFactory = new ChannelFactory<IAutoReservationService>("AutoReservationService");
                target = channelFactory.CreateChannel();
            }
            return target;
        }
    }
}
