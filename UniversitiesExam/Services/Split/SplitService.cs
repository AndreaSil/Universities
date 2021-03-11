using UniversitiesExam.Services.Exceptions;

namespace UniversitiesExam.Services.Split
{
    public class SplitService:ISplitService
    {
        public string[] AplicaSplit(string valor, char caracter)
        {
            var collectionString = valor.Split(caracter);

            try
            {
                if (collectionString.Length==1)
                {
                    throw new ServiceException("No se ha podido separar la cadena");
                }

                return collectionString;
            }
            catch (ServiceException ex)
            {
                throw new SplitException("No se ha podido separar la cadena", ex);
            }
        }
    }
}
