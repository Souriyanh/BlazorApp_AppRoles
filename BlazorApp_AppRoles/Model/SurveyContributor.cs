using Microsoft.Graph;

namespace BlazorApp_AppRoles.Model
{
    public class SurveyContributor
    {
        public int SurveyId { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public Survey Survey { get; set; }
        public User User { get; set; }
    }
}
