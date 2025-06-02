
namespace Dental_Clinic
{
    [Serializable]
    internal class DentalClinicException : Exception
    {
        public DentalClinicException()
        {
        }

        public DentalClinicException(string? message) : base(message)
        {
        }

        public DentalClinicException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}