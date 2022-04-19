using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Street_Light
{
    public class Root
    {
        public string type { get; set; }
        public string payload__applicationID { get; set; }
        public string payload__applicationName { get; set; }
        public string payload__deviceName { get; set; }
        public string payload__devEUI { get; set; }
        public string payload__rxInfo__gatewayID { get; set; }
        public string payload__rxInfo__time { get; set; }
        public string payload__rxInfo__rssi { get; set; }
        public string payload__rxInfo__loRaSNR { get; set; }
        public string payload__rxInfo__channel { get; set; }
        public string payload__rxInfo__rfChain { get; set; }
        public string payload__rxInfo__location__altitude { get; set; }
        public string payload__rxInfo__context { get; set; }
        public string payload__rxInfo__uplinkID { get; set; }
        public string payload__txInfo__frequency { get; set; }
        public string payload__txInfo__modulation { get; set; }
        public string payload__txInfo__loRaModulationInfo__bandwidth { get; set; }
        public string payload__txInfo__loRaModulationInfo__spreadingFactor { get; set; }
        public string payload__txInfo__loRaModulationInfo__codeRate { get; set; }
        public bool payload__txInfo__loRaModulationInfo__polarizationInversion { get; set; }
        public bool payload__adr { get; set; }
        public string payload__dr { get; set; }
        public string payload__fCnt { get; set; }
        public string payload__fPort { get; set; }
        public string payload__data { get; set; }
        public bool payload__confirmedUplink { get; set; }
        public string payload__devAddr { get; set; }
    }
}
