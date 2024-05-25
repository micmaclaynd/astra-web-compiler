namespace WorkspaceMicroservice.Interfaces {
    public class IDeleteWorkspaceHttpRequest {
        public int Id { get; set; }
        public string Path { get; set; }
    }

    public class IDeleteWorkspaceHttpResponse {
        public string Path { get; set; }
    }
}
