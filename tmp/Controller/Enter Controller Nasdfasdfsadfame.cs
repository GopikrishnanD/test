using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.EnterpriseService.Cache;
using System.ServiceModel.Web;
using Molina.EnterpriseService.BusinessLayer;
namespace sadfsadf
{
	public class Enter Controller Nasdfasdfsadfame: ApiController
	{

	  sdaf sdaf = new sdaf();

		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberAuthorization")] 
		public MemberAuthorizationResponse GetMemberAuthorization(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberAuthorization(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberEnrollment")] 
		public MemberEnrollmentResponse GetMemberEnrollment(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberEnrollment(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberEnrollment")] 
		public MemberEnrollmentResponse GetMemberEnrollment(MemberRequest memberRequest, String testing) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberEnrollment(memberRequest, testing); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberPcp")] 
		public MemberPcpResponse GetMemberPcp(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberPcp(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberMemo")] 
		public MemberMemoResponse GetMemberMemo(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberMemo(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberClaims")] 
		public MemberClaimResponse GetMemberClaims(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberClaims(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPut]  
		[Route("api/Enter Controller Nasdfasdfsadfame/UpdateQNXTMailingAddress")] 
		public MemberQNXTMailingAddressUpdateResponse UpdateQNXTMailingAddress(MemberQNXTMailingAddressUpdateRequest memberQNXTMailingAddrUpdateRequest) 
		{ 
 
			try 
			{  
				return sdaf.UpdateQNXTMailingAddress(memberQNXTMailingAddrUpdateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetEnrollRestriction")] 
		public EnrollRestrictionResponse GetEnrollRestriction(EnrollRestrictionRequest enrollRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetEnrollRestriction(enrollRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetRateCode")] 
		public RateCodeResponse GetRateCode(RateCodeRequest memberRateRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetRateCode(memberRateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetAttribute")] 
		public AttributeResponse GetAttribute(AttributeRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetAttribute(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetPlanAction")] 
		public MemberPlanActionResponse GetPlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetPlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpDelete]  
		[Route("api/Enter Controller Nasdfasdfsadfame/DeletePlanAction")] 
		public MemberPlanActionResponse DeletePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.DeletePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPost]  
		[Route("api/Enter Controller Nasdfasdfsadfame/CreatePlanAction")] 
		public MemberPlanActionResponse CreatePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.CreatePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberMemoAlertIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoAlertIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberMemoAlertIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberMemoHedisIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoHedisIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberMemoHedisIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberPrimaryPCP")] 
		public PrimaryPCPReponse GetMemberPrimaryPCP(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberPrimaryPCP(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberProfileSummary")] 
		public MemberProfileSummaryResponse GetMemberProfileSummary(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberProfileSummary(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberAgencyName")] 
		public MemberAgencyNameResponse GetMemberAgencyName(MemberAgencyNameRequest AgencyNameRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberAgencyName(AgencyNameRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberShareOfCost")] 
		public ShareOfCostReponse GetMemberShareOfCost(ShareOfCostRequest costRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberShareOfCost(costRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberBasicUMDetails")] 
		public UMBasicResponse GetMemberBasicUMDetails(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberBasicUMDetails(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetUMDiagsAndServices")] 
		public UMDiagsAndServicesResponse GetUMDiagsAndServices(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetUMDiagsAndServices(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetUMAttributes")] 
		public AttributeDetailsResponse GetUMAttributes(UMDocRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetUMAttributes(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetHedisAlert")] 
		public HedisAlertResponse GetHedisAlert(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetHedisAlert(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetIdCardCompletionDate")] 
		public IdCardCompletionResponse GetIdCardCompletionDate(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetIdCardCompletionDate(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetHistoricalAddress")] 
		public HistoricalAddressResponse GetHistoricalAddress(HistoricalAddressRequest HistoricalAddressRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetHistoricalAddress(HistoricalAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMarketplaceDetail")] 
		public MarketPlaceResponse GetMarketplaceDetail(MarketPlaceRequest MarketPlaceRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetMarketplaceDetail(MarketPlaceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetAccountStatus")] 
		public AccountStatusResponse GetAccountStatus(AccountStatusRequest AccountStatusRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetAccountStatus(AccountStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetBenefitPlan")] 
		public BenefitPlanResponse GetBenefitPlan(BenefitPlanRequest benefitPlanRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetBenefitPlan(benefitPlanRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetBenefitPlanAccumulation")] 
		public BenefitPlanAccumulationResponse GetBenefitPlanAccumulation(BenefitPlanAccumulationRequest benefitPlanAccumulationRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetBenefitPlanAccumulation(benefitPlanAccumulationRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetAssociatedMembers")] 
		public AssociatedMembersResponse GetAssociatedMembers(AssociatedMembersRequest associatedMemberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetAssociatedMembers(associatedMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetProfileSummary")] 
		public ProfileSummaryResponse GetProfileSummary(ProfileSummaryRequest profileSummaryRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetProfileSummary(profileSummaryRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetPrimaryEnrollment")] 
		public PrimaryEnrollmentResponse GetPrimaryEnrollment(PrimaryEnrollmentRequest primaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetPrimaryEnrollment(primaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetSecondaryEnrollment")] 
		public SecondaryEnrollmentResponse GetSecondaryEnrollment(SecondaryEnrollmentRequest SecondaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetSecondaryEnrollment(SecondaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetCOBDetails")] 
		public COBDetailsResponse GetCOBDetails(COBDetailsRequest cobDetailsRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetCOBDetails(cobDetailsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetEnrollPlanActions")] 
		public EnrollPlanActionsResponse GetEnrollPlanActions(EnrollPlanActionsRequest enrollPlanActionsRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetEnrollPlanActions(enrollPlanActionsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/SearchMember")] 
		public MemberSearchResponse SearchMember(SearchMemberRequest searchMemberRequest) 
		{ 
 
			try 
			{  
				return sdaf.SearchMember(searchMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/SearchPreEnrolledMember")] 
		public SearchPreEnrolledMemberResponse SearchPreEnrolledMember(SearchPreEnrolledMemberRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sdaf.SearchPreEnrolledMember(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetPreEnrolledMemberDetail")] 
		public PreEnrolledMemberDetailResponse GetPreEnrolledMemberDetail(PreEnrolledMemberDetailRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetPreEnrolledMemberDetail(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetResendStatus")] 
		public ResendStatusResponse GetResendStatus(ResendStatusRequest resendStatusRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetResendStatus(resendStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetMemberInvoice")] 
		public MemberInvoiceResponse GetMemberInvoice(MarketPlaceRequest request) 
		{ 
 
			try 
			{  
				return sdaf.GetMemberInvoice(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetClaimExplanationOfBenefits")] 
		public EOBPDFDetailResponse GetClaimExplanationOfBenefits(EOBPDFDetailRequest request) 
		{ 
 
			try 
			{  
				return sdaf.GetClaimExplanationOfBenefits(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetResponsiblePartyAddress")] 
		public ResponsiblePartyAddressResponse GetResponsiblePartyAddress(ResponsiblePartyAddressRequest responsiblePartyAddressRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetResponsiblePartyAddress(responsiblePartyAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/Enter Controller Nasdfasdfsadfame/GetClaimDetails")] 
		public QNXTClaimSvc.GetClaimDetailResp GetClaimDetails(ClaimsServiceRequest claimServiceRequest) 
		{ 
 
			try 
			{  
				return sdaf.GetClaimDetails(claimServiceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
	}

}
