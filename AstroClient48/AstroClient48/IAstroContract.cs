using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AstroClient48
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double observedWavelength, double restWavelength);

        [OperationContract]
        double StarDistance(double parallaxAngle);

        [OperationContract]
        double CelsiusToKelvin(double celsius);

        [OperationContract]
        double BlackholeEventHorizon(double mass);
    }
}
