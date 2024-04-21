namespace Application.DTO.Auth
{
	public record ChangePasswordRequest(string AccessToken, string OldPassword, string NewPassword);
}
