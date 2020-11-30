using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WpfApp1.Serialisation
{
    public class SerialisationXML
    {
        public static void Serialiser(List<Personne> questions)
        {
            List<Personne> p = SerialisationXML.InitPersonnes(questions);

            string chemin = Path.Combine(Elements.CHEMIN_EXPORT, Elements.XML);

            XmlSerializer serializer = new XmlSerializer(typeof(Personne));
            using (StreamWriter writer = new StreamWriter(chemin))
            {
                serializer.Serialize(writer, p);
            }

        }

        public static Personne Deserialise(FileInfo file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Personne));
            using (StreamReader reader = new StreamReader(file.FullName))
            {
                return serializer.Deserialize(reader) as Personne;
            }
        }
    }
}
