using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.EnterpriseService.Cache;
using System.ServiceModel.Web;
using Molina.EnterpriseService.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.EnterpriseService.Cache;
using System.ServiceModel.Web;
using Molina.EnterpriseService.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.EnterpriseService.Cache;
using System.ServiceModel.Web;
using Molina.EnterpriseService.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.EnterpriseService.Cache;
using System.ServiceModel.Web;
using Molina.EnterpriseService.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.EnterpriseService.Cache;
using System.ServiceModel.Web;
using Molina.EnterpriseService.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.EnterpriseService.Cache;
using System.ServiceModel.Web;
using Molina.EnterpriseService.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.EnterpriseService.Cache;
using System.ServiceModel.Web;
using Molina.EnterpriseService.BusinessLayer;
namespace Devcare.Projects
{
	public class SampleController: ApiController
	{

	  SampleEngine sampleengine = new SampleEngine();

		[HttpPut]  
		[Route("api/SampleController/GetMemberAuthorization")] 
		public MemberAuthorizationResponse GetMemberAuthorization(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberAuthorization(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberEnrollment")] 
		public MemberEnrollmentResponse GetMemberEnrollment(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberEnrollment(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPost]  
		[Route("api/SampleController/MemberEnrollment")] 
		public MemberEnrollmentResponse GetMemberEnrollment(MemberRequest memberRequest, String testing) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberEnrollment(memberRequest, testing); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberPcp")] 
		public MemberPcpResponse GetMemberPcp(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberPcp(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberMemo")] 
		public MemberMemoResponse GetMemberMemo(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberMemo(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberClaims")] 
		public MemberClaimResponse GetMemberClaims(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberClaims(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPut]  
		[Route("api/SampleController/UpdateQNXTMailingAddress")] 
		public MemberQNXTMailingAddressUpdateResponse UpdateQNXTMailingAddress(MemberQNXTMailingAddressUpdateRequest memberQNXTMailingAddrUpdateRequest) 
		{ 
 
			try 
			{  
				return sampleengine.UpdateQNXTMailingAddress(memberQNXTMailingAddrUpdateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetEnrollRestriction")] 
		public EnrollRestrictionResponse GetEnrollRestriction(EnrollRestrictionRequest enrollRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetEnrollRestriction(enrollRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetRateCode")] 
		public RateCodeResponse GetRateCode(RateCodeRequest memberRateRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetRateCode(memberRateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetAttribute")] 
		public AttributeResponse GetAttribute(AttributeRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetAttribute(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetPlanAction")] 
		public MemberPlanActionResponse GetPlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetPlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpDelete]  
		[Route("api/SampleController/DeletePlanAction")] 
		public MemberPlanActionResponse DeletePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.DeletePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPost]  
		[Route("api/SampleController/CreatePlanAction")] 
		public MemberPlanActionResponse CreatePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.CreatePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberMemoAlertIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoAlertIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberMemoAlertIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberMemoHedisIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoHedisIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberMemoHedisIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberPrimaryPCP")] 
		public PrimaryPCPReponse GetMemberPrimaryPCP(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberPrimaryPCP(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberProfileSummary")] 
		public MemberProfileSummaryResponse GetMemberProfileSummary(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberProfileSummary(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberAgencyName")] 
		public MemberAgencyNameResponse GetMemberAgencyName(MemberAgencyNameRequest AgencyNameRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberAgencyName(AgencyNameRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberShareOfCost")] 
		public ShareOfCostReponse GetMemberShareOfCost(ShareOfCostRequest costRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberShareOfCost(costRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberBasicUMDetails")] 
		public UMBasicResponse GetMemberBasicUMDetails(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberBasicUMDetails(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetUMDiagsAndServices")] 
		public UMDiagsAndServicesResponse GetUMDiagsAndServices(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetUMDiagsAndServices(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetUMAttributes")] 
		public AttributeDetailsResponse GetUMAttributes(UMDocRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetUMAttributes(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetHedisAlert")] 
		public HedisAlertResponse GetHedisAlert(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetHedisAlert(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetIdCardCompletionDate")] 
		public IdCardCompletionResponse GetIdCardCompletionDate(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetIdCardCompletionDate(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetHistoricalAddress")] 
		public HistoricalAddressResponse GetHistoricalAddress(HistoricalAddressRequest HistoricalAddressRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetHistoricalAddress(HistoricalAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMarketplaceDetail")] 
		public MarketPlaceResponse GetMarketplaceDetail(MarketPlaceRequest MarketPlaceRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMarketplaceDetail(MarketPlaceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetAccountStatus")] 
		public AccountStatusResponse GetAccountStatus(AccountStatusRequest AccountStatusRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetAccountStatus(AccountStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetBenefitPlan")] 
		public BenefitPlanResponse GetBenefitPlan(BenefitPlanRequest benefitPlanRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetBenefitPlan(benefitPlanRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetBenefitPlanAccumulation")] 
		public BenefitPlanAccumulationResponse GetBenefitPlanAccumulation(BenefitPlanAccumulationRequest benefitPlanAccumulationRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetBenefitPlanAccumulation(benefitPlanAccumulationRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetAssociatedMembers")] 
		public AssociatedMembersResponse GetAssociatedMembers(AssociatedMembersRequest associatedMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetAssociatedMembers(associatedMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetProfileSummary")] 
		public ProfileSummaryResponse GetProfileSummary(ProfileSummaryRequest profileSummaryRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetProfileSummary(profileSummaryRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetPrimaryEnrollment")] 
		public PrimaryEnrollmentResponse GetPrimaryEnrollment(PrimaryEnrollmentRequest primaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetPrimaryEnrollment(primaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetSecondaryEnrollment")] 
		public SecondaryEnrollmentResponse GetSecondaryEnrollment(SecondaryEnrollmentRequest SecondaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetSecondaryEnrollment(SecondaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetCOBDetails")] 
		public COBDetailsResponse GetCOBDetails(COBDetailsRequest cobDetailsRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetCOBDetails(cobDetailsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetEnrollPlanActions")] 
		public EnrollPlanActionsResponse GetEnrollPlanActions(EnrollPlanActionsRequest enrollPlanActionsRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetEnrollPlanActions(enrollPlanActionsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/SearchMember")] 
		public MemberSearchResponse SearchMember(SearchMemberRequest searchMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.SearchMember(searchMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/SearchPreEnrolledMember")] 
		public SearchPreEnrolledMemberResponse SearchPreEnrolledMember(SearchPreEnrolledMemberRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.SearchPreEnrolledMember(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetPreEnrolledMemberDetail")] 
		public PreEnrolledMemberDetailResponse GetPreEnrolledMemberDetail(PreEnrolledMemberDetailRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetPreEnrolledMemberDetail(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetResendStatus")] 
		public ResendStatusResponse GetResendStatus(ResendStatusRequest resendStatusRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetResendStatus(resendStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberInvoice")] 
		public MemberInvoiceResponse GetMemberInvoice(MarketPlaceRequest request) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberInvoice(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetClaimExplanationOfBenefits")] 
		public EOBPDFDetailResponse GetClaimExplanationOfBenefits(EOBPDFDetailRequest request) 
		{ 
 
			try 
			{  
				return sampleengine.GetClaimExplanationOfBenefits(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetResponsiblePartyAddress")] 
		public ResponsiblePartyAddressResponse GetResponsiblePartyAddress(ResponsiblePartyAddressRequest responsiblePartyAddressRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetResponsiblePartyAddress(responsiblePartyAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetClaimDetails")] 
		public QNXTClaimSvc.GetClaimDetailResp GetClaimDetails(ClaimsServiceRequest claimServiceRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetClaimDetails(claimServiceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberAuthorization")] 
		public MemberAuthorizationResponse GetMemberAuthorization(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberAuthorization(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberEnrollment")] 
		public MemberEnrollmentResponse GetMemberEnrollment(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberEnrollment(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberEnrollment")] 
		public MemberEnrollmentResponse GetMemberEnrollment(MemberRequest memberRequest, String testing) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberEnrollment(memberRequest, testing); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberPcp")] 
		public MemberPcpResponse GetMemberPcp(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberPcp(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberMemo")] 
		public MemberMemoResponse GetMemberMemo(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberMemo(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberClaims")] 
		public MemberClaimResponse GetMemberClaims(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberClaims(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPut]  
		[Route("api/SampleController/UpdateQNXTMailingAddress")] 
		public MemberQNXTMailingAddressUpdateResponse UpdateQNXTMailingAddress(MemberQNXTMailingAddressUpdateRequest memberQNXTMailingAddrUpdateRequest) 
		{ 
 
			try 
			{  
				return sampleengine.UpdateQNXTMailingAddress(memberQNXTMailingAddrUpdateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetEnrollRestriction")] 
		public EnrollRestrictionResponse GetEnrollRestriction(EnrollRestrictionRequest enrollRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetEnrollRestriction(enrollRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetRateCode")] 
		public RateCodeResponse GetRateCode(RateCodeRequest memberRateRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetRateCode(memberRateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetAttribute")] 
		public AttributeResponse GetAttribute(AttributeRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetAttribute(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetPlanAction")] 
		public MemberPlanActionResponse GetPlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetPlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpDelete]  
		[Route("api/SampleController/DeletePlanAction")] 
		public MemberPlanActionResponse DeletePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.DeletePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPost]  
		[Route("api/SampleController/CreatePlanAction")] 
		public MemberPlanActionResponse CreatePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.CreatePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberMemoAlertIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoAlertIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberMemoAlertIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberMemoHedisIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoHedisIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberMemoHedisIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberPrimaryPCP")] 
		public PrimaryPCPReponse GetMemberPrimaryPCP(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberPrimaryPCP(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberProfileSummary")] 
		public MemberProfileSummaryResponse GetMemberProfileSummary(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberProfileSummary(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberAgencyName")] 
		public MemberAgencyNameResponse GetMemberAgencyName(MemberAgencyNameRequest AgencyNameRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberAgencyName(AgencyNameRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberShareOfCost")] 
		public ShareOfCostReponse GetMemberShareOfCost(ShareOfCostRequest costRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberShareOfCost(costRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberBasicUMDetails")] 
		public UMBasicResponse GetMemberBasicUMDetails(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberBasicUMDetails(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetUMDiagsAndServices")] 
		public UMDiagsAndServicesResponse GetUMDiagsAndServices(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetUMDiagsAndServices(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetUMAttributes")] 
		public AttributeDetailsResponse GetUMAttributes(UMDocRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetUMAttributes(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetHedisAlert")] 
		public HedisAlertResponse GetHedisAlert(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetHedisAlert(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetIdCardCompletionDate")] 
		public IdCardCompletionResponse GetIdCardCompletionDate(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetIdCardCompletionDate(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetHistoricalAddress")] 
		public HistoricalAddressResponse GetHistoricalAddress(HistoricalAddressRequest HistoricalAddressRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetHistoricalAddress(HistoricalAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMarketplaceDetail")] 
		public MarketPlaceResponse GetMarketplaceDetail(MarketPlaceRequest MarketPlaceRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMarketplaceDetail(MarketPlaceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetAccountStatus")] 
		public AccountStatusResponse GetAccountStatus(AccountStatusRequest AccountStatusRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetAccountStatus(AccountStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetBenefitPlan")] 
		public BenefitPlanResponse GetBenefitPlan(BenefitPlanRequest benefitPlanRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetBenefitPlan(benefitPlanRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetBenefitPlanAccumulation")] 
		public BenefitPlanAccumulationResponse GetBenefitPlanAccumulation(BenefitPlanAccumulationRequest benefitPlanAccumulationRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetBenefitPlanAccumulation(benefitPlanAccumulationRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetAssociatedMembers")] 
		public AssociatedMembersResponse GetAssociatedMembers(AssociatedMembersRequest associatedMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetAssociatedMembers(associatedMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetProfileSummary")] 
		public ProfileSummaryResponse GetProfileSummary(ProfileSummaryRequest profileSummaryRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetProfileSummary(profileSummaryRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetPrimaryEnrollment")] 
		public PrimaryEnrollmentResponse GetPrimaryEnrollment(PrimaryEnrollmentRequest primaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetPrimaryEnrollment(primaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetSecondaryEnrollment")] 
		public SecondaryEnrollmentResponse GetSecondaryEnrollment(SecondaryEnrollmentRequest SecondaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetSecondaryEnrollment(SecondaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetCOBDetails")] 
		public COBDetailsResponse GetCOBDetails(COBDetailsRequest cobDetailsRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetCOBDetails(cobDetailsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetEnrollPlanActions")] 
		public EnrollPlanActionsResponse GetEnrollPlanActions(EnrollPlanActionsRequest enrollPlanActionsRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetEnrollPlanActions(enrollPlanActionsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/SearchMember")] 
		public MemberSearchResponse SearchMember(SearchMemberRequest searchMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.SearchMember(searchMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/SearchPreEnrolledMember")] 
		public SearchPreEnrolledMemberResponse SearchPreEnrolledMember(SearchPreEnrolledMemberRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.SearchPreEnrolledMember(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetPreEnrolledMemberDetail")] 
		public PreEnrolledMemberDetailResponse GetPreEnrolledMemberDetail(PreEnrolledMemberDetailRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetPreEnrolledMemberDetail(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetResendStatus")] 
		public ResendStatusResponse GetResendStatus(ResendStatusRequest resendStatusRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetResendStatus(resendStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberInvoice")] 
		public MemberInvoiceResponse GetMemberInvoice(MarketPlaceRequest request) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberInvoice(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetClaimExplanationOfBenefits")] 
		public EOBPDFDetailResponse GetClaimExplanationOfBenefits(EOBPDFDetailRequest request) 
		{ 
 
			try 
			{  
				return sampleengine.GetClaimExplanationOfBenefits(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetResponsiblePartyAddress")] 
		public ResponsiblePartyAddressResponse GetResponsiblePartyAddress(ResponsiblePartyAddressRequest responsiblePartyAddressRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetResponsiblePartyAddress(responsiblePartyAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetClaimDetails")] 
		public QNXTClaimSvc.GetClaimDetailResp GetClaimDetails(ClaimsServiceRequest claimServiceRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetClaimDetails(claimServiceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberAuthorization")] 
		public MemberAuthorizationResponse GetMemberAuthorization(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberAuthorization(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberEnrollment")] 
		public MemberEnrollmentResponse GetMemberEnrollment(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberEnrollment(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberPcp")] 
		public MemberPcpResponse GetMemberPcp(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberPcp(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberMemo")] 
		public MemberMemoResponse GetMemberMemo(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberMemo(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberClaims")] 
		public MemberClaimResponse GetMemberClaims(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberClaims(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPut]  
		[Route("api/SampleController/UpdateQNXTMailingAddress")] 
		public MemberQNXTMailingAddressUpdateResponse UpdateQNXTMailingAddress(MemberQNXTMailingAddressUpdateRequest memberQNXTMailingAddrUpdateRequest) 
		{ 
 
			try 
			{  
				return sampleengine.UpdateQNXTMailingAddress(memberQNXTMailingAddrUpdateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetEnrollRestriction")] 
		public EnrollRestrictionResponse GetEnrollRestriction(EnrollRestrictionRequest enrollRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetEnrollRestriction(enrollRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetRateCode")] 
		public RateCodeResponse GetRateCode(RateCodeRequest memberRateRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetRateCode(memberRateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetAttribute")] 
		public AttributeResponse GetAttribute(AttributeRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetAttribute(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetPlanAction")] 
		public MemberPlanActionResponse GetPlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetPlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpDelete]  
		[Route("api/SampleController/DeletePlanAction")] 
		public MemberPlanActionResponse DeletePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.DeletePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPost]  
		[Route("api/SampleController/CreatePlanAction")] 
		public MemberPlanActionResponse CreatePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.CreatePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberMemoAlertIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoAlertIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberMemoAlertIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberMemoHedisIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoHedisIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberMemoHedisIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberPrimaryPCP")] 
		public PrimaryPCPReponse GetMemberPrimaryPCP(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberPrimaryPCP(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberProfileSummary")] 
		public MemberProfileSummaryResponse GetMemberProfileSummary(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberProfileSummary(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberAgencyName")] 
		public MemberAgencyNameResponse GetMemberAgencyName(MemberAgencyNameRequest AgencyNameRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberAgencyName(AgencyNameRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberShareOfCost")] 
		public ShareOfCostReponse GetMemberShareOfCost(ShareOfCostRequest costRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberShareOfCost(costRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberBasicUMDetails")] 
		public UMBasicResponse GetMemberBasicUMDetails(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberBasicUMDetails(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetUMDiagsAndServices")] 
		public UMDiagsAndServicesResponse GetUMDiagsAndServices(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetUMDiagsAndServices(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetUMAttributes")] 
		public AttributeDetailsResponse GetUMAttributes(UMDocRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetUMAttributes(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetHedisAlert")] 
		public HedisAlertResponse GetHedisAlert(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetHedisAlert(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetIdCardCompletionDate")] 
		public IdCardCompletionResponse GetIdCardCompletionDate(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetIdCardCompletionDate(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetHistoricalAddress")] 
		public HistoricalAddressResponse GetHistoricalAddress(HistoricalAddressRequest HistoricalAddressRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetHistoricalAddress(HistoricalAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMarketplaceDetail")] 
		public MarketPlaceResponse GetMarketplaceDetail(MarketPlaceRequest MarketPlaceRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetMarketplaceDetail(MarketPlaceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetAccountStatus")] 
		public AccountStatusResponse GetAccountStatus(AccountStatusRequest AccountStatusRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetAccountStatus(AccountStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetBenefitPlan")] 
		public BenefitPlanResponse GetBenefitPlan(BenefitPlanRequest benefitPlanRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetBenefitPlan(benefitPlanRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetBenefitPlanAccumulation")] 
		public BenefitPlanAccumulationResponse GetBenefitPlanAccumulation(BenefitPlanAccumulationRequest benefitPlanAccumulationRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetBenefitPlanAccumulation(benefitPlanAccumulationRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetAssociatedMembers")] 
		public AssociatedMembersResponse GetAssociatedMembers(AssociatedMembersRequest associatedMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetAssociatedMembers(associatedMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetProfileSummary")] 
		public ProfileSummaryResponse GetProfileSummary(ProfileSummaryRequest profileSummaryRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetProfileSummary(profileSummaryRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetPrimaryEnrollment")] 
		public PrimaryEnrollmentResponse GetPrimaryEnrollment(PrimaryEnrollmentRequest primaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetPrimaryEnrollment(primaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetSecondaryEnrollment")] 
		public SecondaryEnrollmentResponse GetSecondaryEnrollment(SecondaryEnrollmentRequest SecondaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetSecondaryEnrollment(SecondaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetCOBDetails")] 
		public COBDetailsResponse GetCOBDetails(COBDetailsRequest cobDetailsRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetCOBDetails(cobDetailsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetEnrollPlanActions")] 
		public EnrollPlanActionsResponse GetEnrollPlanActions(EnrollPlanActionsRequest enrollPlanActionsRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetEnrollPlanActions(enrollPlanActionsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/SearchMember")] 
		public MemberSearchResponse SearchMember(SearchMemberRequest searchMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.SearchMember(searchMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/SearchPreEnrolledMember")] 
		public SearchPreEnrolledMemberResponse SearchPreEnrolledMember(SearchPreEnrolledMemberRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.SearchPreEnrolledMember(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetPreEnrolledMemberDetail")] 
		public PreEnrolledMemberDetailResponse GetPreEnrolledMemberDetail(PreEnrolledMemberDetailRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetPreEnrolledMemberDetail(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetResendStatus")] 
		public ResendStatusResponse GetResendStatus(ResendStatusRequest resendStatusRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetResendStatus(resendStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetMemberInvoice")] 
		public MemberInvoiceResponse GetMemberInvoice(MarketPlaceRequest request) 
		{ 
 
			try 
			{  
				return sampleengine.GetMemberInvoice(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetClaimExplanationOfBenefits")] 
		public EOBPDFDetailResponse GetClaimExplanationOfBenefits(EOBPDFDetailRequest request) 
		{ 
 
			try 
			{  
				return sampleengine.GetClaimExplanationOfBenefits(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetResponsiblePartyAddress")] 
		public ResponsiblePartyAddressResponse GetResponsiblePartyAddress(ResponsiblePartyAddressRequest responsiblePartyAddressRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetResponsiblePartyAddress(responsiblePartyAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/SampleController/GetClaimDetails")] 
		public QNXTClaimSvc.GetClaimDetailResp GetClaimDetails(ClaimsServiceRequest claimServiceRequest) 
		{ 
 
			try 
			{  
				return sampleengine.GetClaimDetails(claimServiceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
	}

}
