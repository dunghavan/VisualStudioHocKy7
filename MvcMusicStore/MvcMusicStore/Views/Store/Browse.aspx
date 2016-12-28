<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcMusicStore.ViewModels.StoreBrowseViewModel>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Browse Album</title>
</head>
<body>
    <div>
        Browsing Genre: <%:Model.Genre.Name %>
        <ul>
            <% foreach (var album in Model.Albums) 
               { %>
                    <li><%: album.Tittle %></li>
            <% } %>
        </ul>
    </div>
</body>
</html>
