using System.Net.NetworkInformation;
using System.Text;

//injecting a class
//classes are stored on the heap
//classes are datafactories

//Pinging Google DNS Server 4.2.2.2

//does most of the code
Ping pingSender = new Ping();
PingOptions options = new PingOptions();

options.DontFragment = true;

string data = "Learn to code";
byte[] buffer = Encoding.ASCII.GetBytes(data);
int timeout = 120;
string address = "8.8.8.8";
PingReply reply = pingSender.Send(address, timeout, buffer, options);
if (reply.Status == IPStatus.Success)

{
    Console.WriteLine("IP: {0}", address);
    Console.WriteLine("Respone: {0}", reply.Status.ToString());
    Console.WriteLine("RoundTrip: {0}", reply.RoundtripTime);
    Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
}




