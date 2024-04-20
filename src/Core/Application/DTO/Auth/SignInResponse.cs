namespace Application.DTO.Auth
{
	public record SignInResponse(string RefreshToken, string AccessToken);
}
