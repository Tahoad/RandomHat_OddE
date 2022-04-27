<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mainpage.aspx.cs" Inherits="RandomHat_OddE.Mainpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Hat V1.000</title>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=K2D:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800&display=swap');

        html {
            font-family: "K2D";
        }

        body {
            /*font-family: "K2D";*/
            margin: 0;
            padding: 0;
        }

        nav {
            background: linear-gradient(90deg, rgba(131,58,180,1) 0%, rgba(253,29,29,1) 50%, rgba(252,176,69,1) 100%);
            height: 60px;
            width: 100%;
        }

        .container {
            margin-top: 10px;
            background: linear-gradient(90deg, rgba(129,127,128,1) 0%, rgba(255,211,175,1) 100%);
            height: 100vh;
            width: 100vw;
            display: flex;
            align-items: center;
            align-content: center;
            justify-content: center;
        }

        #pnlRandom :hover {
            transition: all 0.5s;
            transform: rotate(90deg);
        }

        #pnlRandom input {
            font-family: "K2D";
            border-radius: 20px;
            height: 50px;
            padding: 0 20px 0 20px;
            background-color: white;
            color: green;
            border: 0px;
            transition: all 0.5s
        }

            #pnlRandom input:hover {
                transform: scale(1.2);
                transition-duration: 0.5s;
                background-color: green;
                color: white;
            }

        #pnlAllocated {
            height: 100%;
            width: 100%;
        }

            #pnlAllocated textarea, input {
                font-family: "K2D";
                border-radius: 20px;
                padding: 0 20px 0 20px;
                background-color: white;
                color: green;
                border: 0px;
                transition: all 0.5s;
                height: 100%;
            }

            #pnlAllocated textarea {
                padding: 10px 20px 10px 20px;
            }

                #pnlAllocated textarea:hover, input:hover {
                    transition-duration: 0.5s;
                    background-color: green;
                    color: white;
                }

            #pnlAllocated #btnClosePnlAllocated {
                border-radius: 20px;
                height: 50px;
                padding: 0 20px 0 20px;
                background-color: white;
                color: red;
                border: 0px;
                transition: all 0.5s
            }

                #pnlAllocated #btnClosePnlAllocated:hover {
                    transform: scale(1.2);
                    transition-duration: 0.5s;
                    background-color: red;
                    color: white;
                }

        .badge-group {
            height: 60px;
            width: 60px;
            z-index: 999;
            display: flex;
            position: absolute;
            right: -20px;
            top: -10px;
            animation:badge-animation;
            animation-duration:3s;
            animation-iteration-count:infinite;
        }

        @keyframes magic-random {
            0% {
            }

            50% {
            }

            100% {
            }
        }
        @keyframes badge-animation{
            100%{
                transform:rotate(360deg);
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
                <div style="display: flex; align-items: center; align-content: center">
                    <a style="display: flex; align-content: center; align-items: center; color: white;" href="mainpage.aspx">
                        <img src="assets/images/random_hat.png" alt="hat icon" style="height: 40px; width: 40px; padding-left: 20px;" />
                        <p style="padding-left: 20px;">Random Hat Application</p>
                    </a>
                </div>
            </nav>
            <div class="container">
                <asp:Panel runat="server" ID="pnlRandom">
                    <asp:Button runat="server" Text="Let's Random Student" ID="btnRandom" OnClick="btnRandom_Click" />
                </asp:Panel>
                <asp:Panel runat="server" ID="pnlAllocated">
                    <div style="display: flex; flex-direction: column; position: relative; height: 100%; margin-left: 2rem; margin-right: 2rem;">
                        <div style="display: flex; justify-content: space-between; padding-top: 20px;">
                            <div style="display: flex;">
                                <div>
                                    <img src="assets/images/random_hat.png" alt="hat icon" style="height: 80%;" />
                                </div>
                                <div style="display: flex; justify-content: flex-start; align-items: center;">
                                    <p style="color: white;">Hmm, difficult. VERY difficult. Plenty of courage, I see. Not a bad mind, either.</p>
                                </div>
                            </div>
                            <div>
                                <asp:Button runat="server" ID="btnClosePnlAllocated" Text="(X) Close" OnClick="btnClosePnlAllocated_Click" />
                            </div>
                        </div>
                        <div style="display: flex; justify-content: space-between; margin-left: 2rem; margin-right: 2rem; height: 100%;">
                            <div style="display: flex; flex-direction: column; height: 100%; position: relative;">
                                <div style="height: 10%; margin-bottom: 10px;">
                                    <img class="badge-group" src="assets/images/Gryffindor.png" />
                                    <asp:TextBox runat="server" ID="txtGroup1_Member_Count" Style="display: flex; z-index: 0;"></asp:TextBox>
                                </div>
                                <div style="height: 70%;">
                                    <asp:TextBox runat="server" ID="txtGroup1_Member_Name" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                            <div style="display: flex; flex-direction: column; height: 100%; position: relative;">
                                <div style="height: 10%; margin-bottom: 10px;">
                                    <img class="badge-group" src="assets/images/Hufflepuff.png" />
                                    <asp:TextBox runat="server" ID="txtGroup2_Member_Count" Style="display: flex; z-index: 0;"></asp:TextBox>
                                </div>
                                <div style="height: 70%;">
                                    <asp:TextBox runat="server" ID="txtGroup2_Member_Name" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                            <div style="display: flex; flex-direction: column; height: 100%; position: relative;">
                                <div style="height: 10%; margin-bottom: 10px;">
                                    <img class="badge-group" src="assets/images/RavenClaw.png" />
                                    <asp:TextBox runat="server" ID="txtGroup3_Member_Count"></asp:TextBox>
                                </div>
                                <div style="height: 70%;">
                                    <asp:TextBox runat="server" ID="txtGroup3_Member_Name" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                            <div style="display: flex; flex-direction: column; height: 100%; position: relative;">
                                <div style="height: 10%; margin-bottom: 10px;">
                                    <img class="badge-group" src="assets/images/Slytherin.png" />
                                    <asp:TextBox runat="server" ID="txtGroup4_Member_Count"></asp:TextBox>
                                </div>
                                <div style="height: 70%;">
                                    <asp:TextBox runat="server" ID="txtGroup4_Member_Name" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:TextBox runat="server" ID="txtRandomNumber" TextMode="MultiLine"></asp:TextBox>
                </asp:Panel>
            </div>
        </div>
    </form>
</body>
</html>
