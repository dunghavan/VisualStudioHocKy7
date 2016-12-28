<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcMusicStore.ViewModels.StoreIndexViewModel>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        <h3> Browse Genres </h3>
        <p>Select from <%: Model.NumberOfGenre %> genres</p>
    </div>
    <div>
        Store Genres
        <ul>
            <%foreach (string genreName in Model.Genres) { %>
            <li>
                <%: Html.ActionLink(genreName, "Browse", new {genre = genreName}, null) %>
                <% if(ViewBag.Starred.Contains(genreName)) {%>
                <img src="../../Content/Images/star.jpg" alt="Starred element" width=20/>
                <%} %>
            </li>
            <%} %>
        </ul>
        <h5>
            <img src="../../Content/Images/star.jpg" alt="Starred element" width=20/> Starred genres 20% Off
        </h5>
    </div>
</body>
</html>
