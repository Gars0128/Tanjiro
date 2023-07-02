using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Domain;




namespace FitnessClub.Factoriesa
{
    internal class PersonalTraingingMembershipFactory : MembershipFactory

    {
        private readonly decimal _price;
        private readonly string _description;


        public PersonalTraingingMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }
        public override IMembership GetMembership()
        {
            PersonalTrainingMembership membership = new(_price)
            {
                Description = _description

            };

            return membership;
        }
    }
}

