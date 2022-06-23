<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="Evaluacion3Web.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-success text-white">
                    <h3>Ver Lecturas</h3>
                </div>
                <div class="card-body">    
                    <div class="form-group">
                        <label for="medidorDb1">Filtrar por Medidor</label>                        
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        EmptyDataText="No hay Lecturas" ShowHeader="true"
                        OnRowCommand="grillaLecturas_RowCommand"
                        AutoGenerateColumns="false" runat="server" ID="grillaLecturas">
                        <Columns>
                            <asp:BoundField DataField="MedidorLecturas" HeaderText="Tipo Medidor" />
                            <asp:BoundField DataField="FechaLecturas" HeaderText="Fecha" />
                            <asp:BoundField DataField="HoraLecturas" HeaderText="Hora" />
                            <asp:BoundField DataField="MinutosLecturas" HeaderText="Minutos" />
                            <asp:BoundField DataField="ConsumoLecturas" HeaderText="Consumo" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button 
                                        CommandName="eliminar"
                                        CommandArgument='<%# Eval("MedidorLecturas")%>'
                                        runat="server" 
                                        CssClass="btn bg-danger" Text="Eliminar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>