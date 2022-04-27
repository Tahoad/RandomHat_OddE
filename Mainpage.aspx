<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mainpage.aspx.cs" Inherits="RandomHat_OddE.Mainpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Hat V1.000</title>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=K2D:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800&display=swap');

        body {
            margin: 0;
            padding: 0;
            font-family: "K2D";
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

            .container input {
                border-radius: 20px;
                height: 50px;
                padding: 0 20px 0 20px;
                background-color: white;
                color: green;
                border: 0px;
                transition: all 0.5s
            }

                .container input:hover {
                    transform: scale(1.2);
                    transition-duration: 0.5s;
                    background-color: green;
                    color: white;
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
                <asp:Panel runat="server" ID="pnlAllocated" Style="z-index: 999; display: none;">
                    <div>
                        <div>
                        </div>
                        <div>
                            <div style="margin-bottom:10px;">
                                <asp:TextBox runat="server" ID="txtGroup1_Gryffindor"></asp:TextBox>
                            </div>
                            <div style="margin-bottom:10px;">
                                <asp:TextBox runat="server" ID="txtGroup2_Hufflepuff"></asp:TextBox>
                            </div>
                            <div style="margin-bottom:10px;">
                                <asp:TextBox runat="server" ID="txtGroup3_Ravenclaw"></asp:TextBox>
                            </div>
                            <div style="margin-bottom:10px;">
                                <asp:TextBox runat="server" ID="txtGroup4_Slytherin"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </form>
</body>
</html>
