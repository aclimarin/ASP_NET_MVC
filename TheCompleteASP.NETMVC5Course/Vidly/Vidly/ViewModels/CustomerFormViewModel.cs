using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        #region [CONSTRUCTORS]

        public CustomerFormViewModel()
        {
            this.Id = 0;
        }

        public CustomerFormViewModel(IEnumerable<MembershipType> membershipTypes)
        {
            this.MembershipTypes = membershipTypes;
        }

        public CustomerFormViewModel(Customer customer, IEnumerable<MembershipType> membershipTypes)
        {
            this.Id = customer.Id;
            this.Name = customer.Name;
            this.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            this.MembershipTypeId = customer.MembershipTypeId;
            this.Birthdate = customer.Birthdate;

            this.MembershipTypes = membershipTypes;
        }

        #endregion

        #region [PROPERTIS]

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public bool IsSubscribedToNewsletter { get; set; }
        
        [Display(Name = "Membership Type")]
        public byte? MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        
        #endregion
        
        public string Title => Id != 0 ? "Edit Customer" : "New Customer";
    }
}