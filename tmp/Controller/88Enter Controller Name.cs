using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.EnterpriseService.Cache;
using System.ServiceModel.Web;
using Molina.EnterpriseService.BusinessLayer;
namespace sdf
{
	public class 88Enter Controller Name: ApiController
	{

	  sdaf sdf = new sdaf();

		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberAuthorization")] 
		public MemberAuthorizationResponse GetMemberAuthorization(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberAuthorization(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberEnrollment")] 
		public MemberEnrollmentResponse GetMemberEnrollment(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberEnrollment(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberEnrollment")] 
		public MemberEnrollmentResponse GetMemberEnrollment(MemberRequest memberRequest, String testing) 
		{ 
 
			try 
			{  
				return sdf.GetMemberEnrollment(memberRequest, testing); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberPcp")] 
		public MemberPcpResponse GetMemberPcp(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberPcp(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberMemo")] 
		public MemberMemoResponse GetMemberMemo(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberMemo(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberClaims")] 
		public MemberClaimResponse GetMemberClaims(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberClaims(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPut]  
		[Route("api/88Enter Controller Name/UpdateQNXTMailingAddress")] 
		public MemberQNXTMailingAddressUpdateResponse UpdateQNXTMailingAddress(MemberQNXTMailingAddressUpdateRequest memberQNXTMailingAddrUpdateRequest) 
		{ 
 
			try 
			{  
				return sdf.UpdateQNXTMailingAddress(memberQNXTMailingAddrUpdateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetEnrollRestriction")] 
		public EnrollRestrictionResponse GetEnrollRestriction(EnrollRestrictionRequest enrollRequest) 
		{ 
 
			try 
			{  
				return sdf.GetEnrollRestriction(enrollRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetRateCode")] 
		public RateCodeResponse GetRateCode(RateCodeRequest memberRateRequest) 
		{ 
 
			try 
			{  
				return sdf.GetRateCode(memberRateRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetAttribute")] 
		public AttributeResponse GetAttribute(AttributeRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sdf.GetAttribute(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetPlanAction")] 
		public MemberPlanActionResponse GetPlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetPlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpDelete]  
		[Route("api/88Enter Controller Name/DeletePlanAction")] 
		public MemberPlanActionResponse DeletePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.DeletePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpPost]  
		[Route("api/88Enter Controller Name/CreatePlanAction")] 
		public MemberPlanActionResponse CreatePlanAction(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.CreatePlanAction(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberMemoAlertIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoAlertIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberMemoAlertIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberMemoHedisIndicator")] 
		public MemoAlertIndicatorResponse GetMemberMemoHedisIndicator(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberMemoHedisIndicator(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberPrimaryPCP")] 
		public PrimaryPCPReponse GetMemberPrimaryPCP(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberPrimaryPCP(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberProfileSummary")] 
		public MemberProfileSummaryResponse GetMemberProfileSummary(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberProfileSummary(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberAgencyName")] 
		public MemberAgencyNameResponse GetMemberAgencyName(MemberAgencyNameRequest AgencyNameRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberAgencyName(AgencyNameRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberShareOfCost")] 
		public ShareOfCostReponse GetMemberShareOfCost(ShareOfCostRequest costRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberShareOfCost(costRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberBasicUMDetails")] 
		public UMBasicResponse GetMemberBasicUMDetails(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMemberBasicUMDetails(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetUMDiagsAndServices")] 
		public UMDiagsAndServicesResponse GetUMDiagsAndServices(UMDocRequest UMDocRequest) 
		{ 
 
			try 
			{  
				return sdf.GetUMDiagsAndServices(UMDocRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetUMAttributes")] 
		public AttributeDetailsResponse GetUMAttributes(UMDocRequest memberAttributeRequest) 
		{ 
 
			try 
			{  
				return sdf.GetUMAttributes(memberAttributeRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetHedisAlert")] 
		public HedisAlertResponse GetHedisAlert(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetHedisAlert(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetIdCardCompletionDate")] 
		public IdCardCompletionResponse GetIdCardCompletionDate(MemberRequest memberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetIdCardCompletionDate(memberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetHistoricalAddress")] 
		public HistoricalAddressResponse GetHistoricalAddress(HistoricalAddressRequest HistoricalAddressRequest) 
		{ 
 
			try 
			{  
				return sdf.GetHistoricalAddress(HistoricalAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMarketplaceDetail")] 
		public MarketPlaceResponse GetMarketplaceDetail(MarketPlaceRequest MarketPlaceRequest) 
		{ 
 
			try 
			{  
				return sdf.GetMarketplaceDetail(MarketPlaceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetAccountStatus")] 
		public AccountStatusResponse GetAccountStatus(AccountStatusRequest AccountStatusRequest) 
		{ 
 
			try 
			{  
				return sdf.GetAccountStatus(AccountStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetBenefitPlan")] 
		public BenefitPlanResponse GetBenefitPlan(BenefitPlanRequest benefitPlanRequest) 
		{ 
 
			try 
			{  
				return sdf.GetBenefitPlan(benefitPlanRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetBenefitPlanAccumulation")] 
		public BenefitPlanAccumulationResponse GetBenefitPlanAccumulation(BenefitPlanAccumulationRequest benefitPlanAccumulationRequest) 
		{ 
 
			try 
			{  
				return sdf.GetBenefitPlanAccumulation(benefitPlanAccumulationRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetAssociatedMembers")] 
		public AssociatedMembersResponse GetAssociatedMembers(AssociatedMembersRequest associatedMemberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetAssociatedMembers(associatedMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetProfileSummary")] 
		public ProfileSummaryResponse GetProfileSummary(ProfileSummaryRequest profileSummaryRequest) 
		{ 
 
			try 
			{  
				return sdf.GetProfileSummary(profileSummaryRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetPrimaryEnrollment")] 
		public PrimaryEnrollmentResponse GetPrimaryEnrollment(PrimaryEnrollmentRequest primaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sdf.GetPrimaryEnrollment(primaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetSecondaryEnrollment")] 
		public SecondaryEnrollmentResponse GetSecondaryEnrollment(SecondaryEnrollmentRequest SecondaryEnrollmentRequest) 
		{ 
 
			try 
			{  
				return sdf.GetSecondaryEnrollment(SecondaryEnrollmentRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetCOBDetails")] 
		public COBDetailsResponse GetCOBDetails(COBDetailsRequest cobDetailsRequest) 
		{ 
 
			try 
			{  
				return sdf.GetCOBDetails(cobDetailsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetEnrollPlanActions")] 
		public EnrollPlanActionsResponse GetEnrollPlanActions(EnrollPlanActionsRequest enrollPlanActionsRequest) 
		{ 
 
			try 
			{  
				return sdf.GetEnrollPlanActions(enrollPlanActionsRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/SearchMember")] 
		public MemberSearchResponse SearchMember(SearchMemberRequest searchMemberRequest) 
		{ 
 
			try 
			{  
				return sdf.SearchMember(searchMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/SearchPreEnrolledMember")] 
		public SearchPreEnrolledMemberResponse SearchPreEnrolledMember(SearchPreEnrolledMemberRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sdf.SearchPreEnrolledMember(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetPreEnrolledMemberDetail")] 
		public PreEnrolledMemberDetailResponse GetPreEnrolledMemberDetail(PreEnrolledMemberDetailRequest searchPreEnrolledMemberRequest) 
		{ 
 
			try 
			{  
				return sdf.GetPreEnrolledMemberDetail(searchPreEnrolledMemberRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetResendStatus")] 
		public ResendStatusResponse GetResendStatus(ResendStatusRequest resendStatusRequest) 
		{ 
 
			try 
			{  
				return sdf.GetResendStatus(resendStatusRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetMemberInvoice")] 
		public MemberInvoiceResponse GetMemberInvoice(MarketPlaceRequest request) 
		{ 
 
			try 
			{  
				return sdf.GetMemberInvoice(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetClaimExplanationOfBenefits")] 
		public EOBPDFDetailResponse GetClaimExplanationOfBenefits(EOBPDFDetailRequest request) 
		{ 
 
			try 
			{  
				return sdf.GetClaimExplanationOfBenefits(request); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetResponsiblePartyAddress")] 
		public ResponsiblePartyAddressResponse GetResponsiblePartyAddress(ResponsiblePartyAddressRequest responsiblePartyAddressRequest) 
		{ 
 
			try 
			{  
				return sdf.GetResponsiblePartyAddress(responsiblePartyAddressRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
		[HttpGet]  
		[Route("api/88Enter Controller Name/GetClaimDetails")] 
		public QNXTClaimSvc.GetClaimDetailResp GetClaimDetails(ClaimsServiceRequest claimServiceRequest) 
		{ 
 
			try 
			{  
				return sdf.GetClaimDetails(claimServiceRequest); 
			} catch (Exception ex)
			 {
				 throw ex;
			 }
 
			return  null;
		}
 
	}

}
