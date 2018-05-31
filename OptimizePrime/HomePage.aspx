<%@ Page Language="C#" %>

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale = 1" />
    <link rel="stylesheet" href="bootstrap.min.css" />
    <script src=" bootsrap.min.js"></script>
    <link rel="stlyesheet" href="bootstrap-theme.min.css" />
    <title>Home Page</title>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    <link href='https://fonts.googleapis.com/css?family=Pacifico' rel ="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">

            <div class="page-header" style="background-color: gainsboro;">
                <h1>Investec</h1>
            </div>
            
            <div class ="embed-responsive embed-responsive-16by9">
                <iframe width="560" height="315" src="https://www.youtube.com/embed/xpb_gymbx6E"></iframe>
            </div>
            <div></div>
            <div class="row">
                <h4>Who we are</h4>
                <p>Investec is a distinctive specialist bank and asset manager we are grounded in our entrepreneurial culture, which is balanced by a string risk management discipline, client-centric approach and the ability to be innovative.</p>
            </div>
            <div class="row">
                <h4>What we are looking for</h4>
                <p>Whether you are up and coming in your career, or are established we look for go-to individualists characterized by an entrepreneurial mind set, innovative spirit and extraordinary standards of delivery.</p>
            </div>
            <div class ="jumbotron">
                <h4>Apply for the Graduate Program</h4>
                <p>If you feel you are up to the task, be sure to apply for the graduate program!</p>
                <button type="submit" class="btn btn-primary btn-lg">Apply</button>
            </div>
            <div class ="jumbotron">Already applied? Log in to see your application status
            <button type ="button" class ="btn-secondary">Login</button>
                </div>
            <div>
                <img src="Content/ZebraFacePic.jpg" width="500"/>
            </div>
        </div>

        <script src="https://aax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
    </form>
</body>
</html>
