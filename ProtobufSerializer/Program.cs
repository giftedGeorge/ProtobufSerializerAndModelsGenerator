//using ProtoBuf;
using Google.Protobuf;

namespace ProtobufSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Google.Protobuf implementation
            // Create a new instance of the object class
            var request = new GetInventoryRequest
            {
                Id = "123"
            };

            // Serialize the person object to a byte array
            byte[] serializedData = request.ToByteArray();

            // Print the serialized data
            Console.WriteLine($"Serialized GetInventoryRequest Data: {BitConverter.ToString(serializedData)}\n");

            // Deserialize the data back into a Person object
            var deserializedPerson = GetInventoryRequest.Parser.ParseFrom(serializedData);

            // Access the deserialized person properties
            Console.WriteLine($"Deserialized GetInventoryRequest Data: {deserializedPerson.Id}\n");

            Console.WriteLine("Serialization and deserialization completed successfully!");
            Console.ReadLine();
        }
    }
}