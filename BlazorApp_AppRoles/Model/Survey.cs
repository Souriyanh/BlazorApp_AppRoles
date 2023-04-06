using Microsoft.Graph;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp_AppRoles.Model
{
    public class Survey
    {
        public Survey() : this(string.Empty)
        {
        }
        public Survey(string title)
        {
            Title = title;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "* You must provide a Title for the survey.")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        public int OwnerId { get; set; }

        public int TenantId { get; set; }

        public bool Published { get; set; }

        // Navigation properties
        public User Owner { get; set; }
        public virtual ICollection<SurveyContributor> Contributors { get; set; }
    }
}
