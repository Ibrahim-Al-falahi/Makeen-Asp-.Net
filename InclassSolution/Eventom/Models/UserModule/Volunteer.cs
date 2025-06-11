namespace Eventom.Models.UserModule
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string EducationLevel { get; set; }
        public string FieldOfStudy { get; set; }
        public string Skills { get; set; }
        public string Interest { get; set; }
        public string PreviousExperience { get; set; }
        public int TotalEventsParticipated { get; set; }
        public decimal AverageRating { get; set; }
        public string VolunteerLevel { get; set; }
    }
}
