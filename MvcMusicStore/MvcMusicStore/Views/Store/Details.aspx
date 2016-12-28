<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcMusicStore.Models.Album>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
    <div>
        Album: <%:Model.Tittle %>
    </div>
</body>
</html>
