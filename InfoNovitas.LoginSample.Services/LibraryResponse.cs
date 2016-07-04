namespace InfoNovitas.LoginSample.Services
{
    public abstract class LibraryResponse
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
