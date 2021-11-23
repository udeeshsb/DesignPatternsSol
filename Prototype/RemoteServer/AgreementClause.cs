using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class AgreementDto
    {
        public string DeveloperClause { get; set; }
        public string PostDeliveryClause { get; set; }
        public string ProjectTerminationClause { get; set; }
    }
    public class AgreementClause
    {
        public AgreementDto GetAgreementClause()
        {
            AgreementDto agreementDto = new AgreementDto();
            agreementDto.DeveloperClause = "Developer activity shall complete as per milestone.";
            agreementDto.PostDeliveryClause = "Post delivery support of 1 year shall be given";
            agreementDto.ProjectTerminationClause = "Client may terminate the agreement at any point of time.";

            return agreementDto;
        }
    }
}
