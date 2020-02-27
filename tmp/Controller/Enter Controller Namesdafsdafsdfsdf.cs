using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.EnterpriseService.Cache;
using System.ServiceModel.Web;
using Molina.EnterpriseService.BusinessLayer;
namespace sdaf
{
	public class Enter Controller Namesdafsdafsdfsdf: ApiController
	{

	  sdafafs sadf = new sdafafs();

		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberAuthorization")] 
		public MemberAuthorizationResponse GetMemberAuthorization(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberAuthorization(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberEnrollment")] 
		public MemberEnrollmentResponse GetMemberEnrollment(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberEnrollment(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberPcp")] 
		public MemberPcpResponse GetMemberPcp(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberPcp(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberMemo")] 
		public MemberMemoResponse GetMemberMemo(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberMemo(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberClaims")] 
		public MemberClaimResponse GetMemberClaims(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberClaims(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPut]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/UpdateQNXTMailingAddress")] 
		public MemberQNXTMailingAddressUpdateResponse UpdateQNXTMailingAddress(MemberQNXTMailingAddressUpdateRequest memberQNXTMailingAddrUpdateRequest) 
		{ 
 
			try 
			{  
				return sadf.UpdateQNXTMailingAddress(memberQNXTMailingAddrUpdateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetEnrollRestriction")] 
		public EnrollRestrictionResponse GetEnrollRestriction(EnrollRestrictionRequest enrollRequest) 
		{ 
 
			try 
			{  
				return sadf.GetEnrollRestriction(enrollRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetRateCode")] 
		public RateCodeResponse GetRateCode(RateCodeRequest memberRateRequest) 
		{ 
 
			try 
			{  
				return sadf.GetRateCode(memberRateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetAttribute")] 
		public AttributeResponse GetAttribute(AttributeRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sadf.GetAttribute(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetPlanAction")] 
		public MemberPlanActionResponse GetPlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetPlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpDelete]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/DeletePlanAction")] 
		public MemberPlanActionResponse DeletePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.DeletePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPost]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/CreatePlanAction")] 
		public MemberPlanActionResponse CreatePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.CreatePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberMemoAlertIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoAlertIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberMemoAlertIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberMemoHedisIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoHedisIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberMemoHedisIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberPrimaryPCP")] 
		public PrimaryPCPReponse GetMemberPrimaryPCP(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberPrimaryPCP(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberProfileSummary")] 
		public MemberProfileSummaryResponse GetMemberProfileSummary(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberProfileSummary(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberAgencyName")] 
		public MemberAgencyNameResponse GetMemberAgencyName(MemberAgencyNameRequest AgencyNameRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberAgencyName(AgencyNameRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberShareOfCost")] 
		public ShareOfCostReponse GetMemberShareOfCost(ShareOfCostRequest costRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberShareOfCost(costRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberBasicUMDetails")] 
		public UMBasicResponse GetMemberBasicUMDetails(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMemberBasicUMDetails(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetUMDiagsAndServices")] 
		public UMDiagsAndServicesResponse GetUMDiagsAndServices(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sadf.GetUMDiagsAndServices(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetUMAttributes")] 
		public AttributeDetailsResponse GetUMAttributes(UMDocRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sadf.GetUMAttributes(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetHedisAlert")] 
		public HedisAlertResponse GetHedisAlert(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetHedisAlert(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetIdCardCompletionDate")] 
		public IdCardCompletionResponse GetIdCardCompletionDate(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetIdCardCompletionDate(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetHistoricalAddress")] 
		public HistoricalAddressResponse GetHistoricalAddress(HistoricalAddressRequest HistoricalAddressRequest) 
		{ 
 
			try 
			{  
				return sadf.GetHistoricalAddress(HistoricalAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMarketplaceDetail")] 
		public MarketPlaceResponse GetMarketplaceDetail(MarketPlaceRequest MarketPlaceRequest) 
		{ 
 
			try 
			{  
				return sadf.GetMarketplaceDetail(MarketPlaceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetAccountStatus")] 
		public AccountStatusResponse GetAccountStatus(AccountStatusRequest AccountStatusRequest) 
		{ 
 
			try 
			{  
				return sadf.GetAccountStatus(AccountStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetBenefitPlan")] 
		public BenefitPlanResponse GetBenefitPlan(BenefitPlanRequest benefitPlanRequest) 
		{ 
 
			try 
			{  
				return sadf.GetBenefitPlan(benefitPlanRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetBenefitPlanAccumulation")] 
		public BenefitPlanAccumulationResponse GetBenefitPlanAccumulation(BenefitPlanAccumulationRequest benefitPlanAccumulationRequest) 
		{ 
 
			try 
			{  
				return sadf.GetBenefitPlanAccumulation(benefitPlanAccumulationRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetAssociatedMembers")] 
		public AssociatedMembersResponse GetAssociatedMembers(AssociatedMembersRequest associatedMemberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetAssociatedMembers(associatedMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetProfileSummary")] 
		public ProfileSummaryResponse GetProfileSummary(ProfileSummaryRequest profileSummaryRequest) 
		{ 
 
			try 
			{  
				return sadf.GetProfileSummary(profileSummaryRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetPrimaryEnrollment")] 
		public PrimaryEnrollmentResponse GetPrimaryEnrollment(PrimaryEnrollmentRequest primaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sadf.GetPrimaryEnrollment(primaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetSecondaryEnrollment")] 
		public SecondaryEnrollmentResponse GetSecondaryEnrollment(SecondaryEnrollmentRequest SecondaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sadf.GetSecondaryEnrollment(SecondaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetCOBDetails")] 
		public COBDetailsResponse GetCOBDetails(COBDetailsRequest cobDetailsRequest) 
		{ 
 
			try 
			{  
				return sadf.GetCOBDetails(cobDetailsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetEnrollPlanActions")] 
		public EnrollPlanActionsResponse GetEnrollPlanActions(EnrollPlanActionsRequest enrollPlanActionsRequest) 
		{ 
 
			try 
			{  
				return sadf.GetEnrollPlanActions(enrollPlanActionsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/SearchMember")] 
		public MemberSearchResponse SearchMember(SearchMemberRequest searchMemberRequest) 
		{ 
 
			try 
			{  
				return sadf.SearchMember(searchMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/SearchPreEnrolledMember")] 
		public SearchPreEnrolledMemberResponse SearchPreEnrolledMember(SearchPreEnrolledMemberRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sadf.SearchPreEnrolledMember(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetPreEnrolledMemberDetail")] 
		public PreEnrolledMemberDetailResponse GetPreEnrolledMemberDetail(PreEnrolledMemberDetailRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sadf.GetPreEnrolledMemberDetail(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetResendStatus")] 
		public ResendStatusResponse GetResendStatus(ResendStatusRequest resendStatusRequest) 
		{ 
 
			try 
			{  
				return sadf.GetResendStatus(resendStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetMemberInvoice")] 
		public MemberInvoiceResponse GetMemberInvoice(MarketPlaceRequest request) 
		{ 
 
			try 
			{  
				return sadf.GetMemberInvoice(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetClaimExplanationOfBenefits")] 
		public EOBPDFDetailResponse GetClaimExplanationOfBenefits(EOBPDFDetailRequest request) 
		{ 
 
			try 
			{  
				return sadf.GetClaimExplanationOfBenefits(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetResponsiblePartyAddress")] 
		public ResponsiblePartyAddressResponse GetResponsiblePartyAddress(ResponsiblePartyAddressRequest responsiblePartyAddressRequest) 
		{ 
 
			try 
			{  
				return sadf.GetResponsiblePartyAddress(responsiblePartyAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Namesdafsdafsdfsdf/GetClaimDetails")] 
		public QNXTClaimSvc.GetClaimDetailResp GetClaimDetails(ClaimsServiceRequest claimServiceRequest) 
		{ 
 
			try 
			{  
				return sadf.GetClaimDetails(claimServiceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
	}

}
