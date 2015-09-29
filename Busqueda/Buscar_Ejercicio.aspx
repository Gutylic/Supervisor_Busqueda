<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Buscar_Ejercicio.aspx.cs" Inherits="Busqueda.Buscar_Ejercicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
    
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/buscar_ejercicio.css" rel="stylesheet"/>   
    <link href="css/Encabezado.css" rel="stylesheet" />
   
    <title>Buscar Ejercicio</title>

    <script type="text/javascript" src="http://www.wiris.net/demo/editor/editor"></script>
    
	<script type="text/javaScript">

	    var toolbart = '<toolbar ref="general" removeLinks="true"><tab ref="general"><removeItem ref="setFontSize"/><removeItem ref="parenthesis"/><removeItem ref="curlyBracket"/><removeItem ref="squareBracket"/><removeItem ref="setFontFamily"/><removeItem ref="forceLigature"/><removeItem ref="rtl"/><removeItem ref="mtext"/><removeItem ref="setColor"/><removeItem ref="autoItalic"/><removeItem ref="italic"/><removeItem ref="bold"/><removeItem ref="undo"/><removeItem ref="redo"/><removeItem ref="paste"/><removeItem ref="cut"/><removeItem ref="copy"/><removeItem ref="&#247;"/><removeItem ref="+"/><removeItem ref="-"/><removeItem ref="&#215;"/><removeItem ref="&#247"/><removeItem ref="bevelledFraction"/><removeItem ref="/"/></tab><tab ref="symbols"><removeItem ref="&#10878;"/><removeItem ref="&#10877;"/><removeItem ref="*"/><removeItem ref="="/><removeItem ref="<"/><removeItem ref=">"/><removeItem ref="&#247;"/><removeItem ref="+"/><removeItem ref="-"/><removeItem ref="&#215;"/><removeItem ref="&#247"/><removeItem ref="bevelledFraction"/><removeItem ref="/"/></tab><tab ref="greek"><removeItem ref="naturals"/><removeItem ref="rationals"/><removeItem ref="reals"/><removeItem ref="integers"/><removeItem ref="complexes"/><removeItem ref="primes"/><removeItem ref="&#8465;"/><removeItem ref="&#8476;"/><removeItem ref="ell"/><removeItem ref="&#8501;"/><removeItem ref="&#8472;"/><removeItem ref="&#8497;"/><removeItem ref="&#8466;"/><removeItem ref="zTransform"/><removeItem ref="arabicIndicNumbers"/><removeItem ref="easternArabicIndicNumbers"/></tab><tab ref="matrices"><removeItem ref="piecewiseFunction"/><removeItem ref="equationAlign"/></tab><tab ref="scriptsAndLayout"><removeItem ref="bigOpUnderover"/><removeItem ref="bigOpUnder"/><removeItem ref="bigOpSubsuperscript"/><removeItem ref="bigOpSubscript"/><removeItem ref="bevelledFraction"/><removeItem ref="smallBevelledFraction"/><removeItem ref="smallFraction"/><removeItem ref="digitSpace"/><removeItem ref="backSpace"/><removeItem ref="thinnerSpace"/><removeItem ref="thinSpace"/></tab><tab ref="bracketsAndAccents"><removeItem ref="parenthesis"/><removeItem ref="squareBracket"/><removeItem ref="angleBrackets"/><removeItem ref="curlyBracket"/><removeItem ref="openParenthesis"/><removeItem ref="closeParenthesis"/><removeItem ref="openSquareBracket"/><removeItem ref="closeSquareBracket"/><removeItem ref="openAngleBracket"/><removeItem ref="closeAngleBracket"/><removeItem ref="openCurlyBracket"/><removeItem ref="closeCurlyBracket"/></tab><tab ref="bigOps"><removeItem ref="sumSubsuperscript"/><removeItem ref="sumSubscript"/><removeItem ref="productSubsuperscript"/><removeItem ref="productSubscript"/><removeItem ref="bigOpSubsuperscript"/><removeItem ref="bigOpSubscript"/></tab><tab ref="calculus"><removeItem ref="sinus"/><removeItem ref="cosinus"/><removeItem ref="tangent"/><removeItem ref="log"/><removeItem ref="nlog"/><removeItem ref="naturalLog"/><removeItem ref="cosecant"/><removeItem ref="secant"/><removeItem ref="cotangent"/><removeItem ref="arcsinus"/><removeItem ref="arccosinus"/><removeItem ref="arctangent"/></tab>               <tab ref="contextual"><removeItem ref="alignLeft"/><removeItem ref="alignCenter"/><removeItem ref="alignRight"/><removeItem ref="addFrame"/><removeItem ref="removeFrame"/><removeItem ref="matrixSolidLine"/><removeItem ref="matrixDashLine"/><removeItem ref="removeLineBelow"/><removeItem ref="removeLineRight"/><removeItem ref="alignRowsTop"/><removeItem ref="alignRowsCenter"/><removeItem ref="alignRowsBottom"/> <removeItem ref="alignRowsBottom"/><removeItem ref="alignRowsBaseline"/>  <removeItem ref="alignRowsAxis"/><removeItem ref="equalRowHeight"/><removeItem ref="equalColWidth"/><removeItem ref="setColumnSpacing"/><removeItem ref="setRowSpacing"/><removeItem ref="alignLeft"/><removeItem ref="alignCenter"/><removeItem ref="alignRight"/></tab></toolbar>';

	    var editor;
        
	    window.onload = function () {

	        var editor = com.wiris.jsEditor.JsEditor.newInstance({ 'language': 'es', 'toolbar': toolbart });

	        editor.insertInto(document.getElementById('editorContainer'));

	        if ('<%=Session["Contenido_Wiris"]%>' != "") {

	            editor.setMathML('<%=Session["Contenido_Wiris"]%>');

	        };

	        source = 'mathml';

	        lastSource = null;

	        var counter = 0;

	        setInterval(function () {

	            var mathML = editor.getMathML();

	            if (mathML != lastSource) {
                    
	                if (source == 'mathml') {

	                    document.getElementById('source').value = mathML;

	                }
                    
	                lastSource = mathML;

	            }

	        }, 1000);
            
	        window.changeSourceTo = function (newSource) {

	            lastSource = null;

	            source = newSource;

	            document.getElementById('source').value = '';

	            document.getElementById('source').style.color = null;

	            document.getElementById('source_set').style.display = null;

	        }

	        document.getElementById('source_set_button').onclick = function () {

	            if (source == 'mathml') {

	                editor.setMathML(document.getElementById('TextBox_MATH').value);

	            }
                
	        }

	        document.getElementById('source_cancel_button').onclick = function () {

	            if (source == 'mathml') {

	                document.getElementById('TextBox_MATH').value = document.getElementById('source').value

	            }

	        }

	    }

        function validar_numerico(evento) {

            var tecla = document.all ? tecla = evento.which : tecla = evento.keyCode;

            return (tecla > 47 && tecla < 58);

        };

        function Cargar_Variable_CSharp() {

            document.getElementById("Contenido_Wiris").value = editor.getMathML();

        };

    </script>
    
</head>

<body>

    <form id="form1" runat="server">
    


        <div class="container">
             <nav class="navbar navbar-fixed-top header fondo_encabezado">
 	            <div class="container"> 
                                         
                    <div class="row">
                        <div class="col-xs-12 visible-xs administrador" >
                            <asp:Label ID="Administrador_chico" runat="server" Text="">Adm:</asp:Label>
                            <asp:Label ID="Etiqueta_Administrador_Chico" CssClass ="etiqueta_administrador_chico" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="col-xs-12 hidden-xs administrador">
                            <asp:Label ID="Administrador_grande" runat="server" Text="">Administrador:</asp:Label>
                            <asp:Label ID="Etiqueta_Administrador_Grande" CssClass ="etiqueta_administrador_grande" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-4 visible-xs ip chico">
                            <asp:Label ID="Localizador_chico" runat="server">Conectado:</asp:Label>
                            <asp:Label ID="Etiqueta_Localizador_Chico" CssClass ="etiqueta_administrador_chico" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="col-xs-4 hidden-xs ip chico">
                            <asp:Label ID="Localizador_Grande" runat="server">Conectado:</asp:Label>
                            <asp:Label ID="Etiqueta_Localizador_Grande" CssClass ="etiqueta_administrador_chico" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="col-xs-4 consola_de_control" style="text-align:center; ">
                            <h1 class="titulo">Buscador</h1>
                        </div>
                        <div class="col-xs-4 cerrar_session">                             
                            <asp:LinkButton ID="Volver_A_Consola" ToolTip="Volver a Consola de Control" runat="server" OnClick="Volver_A_Consola_Click">X</asp:LinkButton>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 visible-xs hora_chica_num" >
                            <asp:Label ID="Hora_chico" runat="server" >Hora:</asp:Label>
                            <asp:Label ID="Etiqueta_Hora_Chica" runat="server" ></asp:Label>
                        </div>
                        <div class="col-xs-12 hidden-xs hora_grande" >
                            <asp:Label ID="Hora_grande" runat="server" >Hora de Conexión:</asp:Label>
                            <asp:Label ID="Etiqueta_Hora_Grande" runat="server" ></asp:Label>
                        </div>
                    </div>
                </div>
             </nav>
        </div>
      

        <div class="navbar navbar-default" id="subnav">
            <div class="col-xs-12"></div>	
        </div>
       







      
        <div class="container">
            <div class="row">
                    <div class="well pizarra"  >        
                <div class="col-md-7 hidden-sm hidden-xs">
                    <div class="thumbnail editorContainer" >
                        <asp:HiddenField ID="Contenido_Wiris" runat="server" />                    
                        <div id="editorContainer" ></div>                              
                    </div>            
               </div>            
                <div class="col-md-5 col-sm-12">                
                    <textarea id="source" spellcheck="false" style="visibility:hidden"></textarea>
                    <div class="thumbnail TextBox_MATH"  >                   
                        <div class="caption-full">                       
                            <asp:TextBox ID="TextBox_MATH" TextMode="MultiLine"  style="height:300px;" runat="server" Text='<math xmlns="http://www.w3.org/1998/Math/MathML"></math>'></asp:TextBox>                    
                       </div> 
                    </div>
                </div>
            </div>
                </div>
        </div>
        <div class="container">      
            <div class="row">
                
                   <div class="well" >
                         <div class="col-xs-6 archivo"><asp:FileUpload ID="Subir_Archivo" runat="server" /></div>
                         <div class="col-xs-6 cargar"><asp:Button ID="Boton_Para_Leer_Archivo" runat="server"  Text="Cargar" class="btn btn-info" OnClick="Boton_Para_Leer_Archivo_Click"/></div>
                             
                    </div>
               </div>
            
            

            <div class="row hidden-xs">

                <div class="well">
                    <div id="source_set" class="setter">
                        <div class="col-sm-4"><input id="source_cancel_button" type="button" value="Texto => MATH" class="btn btn-success" /></div>
                        <div class="col-sm-4"><input id="source_set_button" type="button" value="Texto <= MATH " class="btn btn-warning" /></div>
                        <div class="col-sm-4"><asp:Button ID="Boton_De_Borrado_Del_TextArea_Math"  runat="server" Text="Borrar" CssClass="btn btn-danger" OnClick="Boton_De_Borrado_Del_TextArea_Math_Click" /></div>
                    </div>
                    
               </div>
           </div>

            <div class="row visible-xs">
                <div class="well" style="margin-top:5px">
                    <div class="col-xs-12"><asp:Button ID="Boton_Borrado_Movil"  runat="server" Width="100%" Text="Borrar" CssClass="btn btn-danger" OnClick="Boton_De_Borrado_Del_TextArea_Math_Click" /></div>
                </div>
            </div>
            
           
            <div class="row hidden-xs">
                <div class="well" style="margin-top:5px">
                    <div class="col-xs-4 profundidad"><asp:TextBox ID="TextBox_Profundidad" runat="server" onKeyPress="return validar_numerico(event)"></asp:TextBox></div>
                    <div class="col-xs-4"><asp:Button ID="Boton_Busqueda_Enunciado_Profundidad" OnClientClick="Cargar_Variable_CSharp()"  runat="server" Text="Buscar x Profundidad" CssClass="btn btn-info" OnClick="Boton_Busqueda_Enunciado_Profundidad_Click"/></div>
                    <div class="col-xs-4"><asp:Button ID="Boton_Busqueda_En_Enunciado_Limpio_Porcentaje" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Buscar x Porcentaje" CssClass="btn btn-primary" OnClick="Boton_Busqueda_En_Enunciado_Limpio_Porcentaje_Click"/></div>
               
                </div>
            </div>
           
          <div class="row visible-xs">
                <div class="well" style="margin-top:5px">
                    <div class="col-xs-4 profundidad"><asp:TextBox ID="TextBox_Profundidad_Movil"  runat="server" onKeyPress="return validar_numerico(event)"></asp:TextBox></div>
                    <div class="col-xs-4"><asp:Button ID="Boton_Busqueda_Enunciado_Profundidad_Movil" OnClientClick="Cargar_Variable_CSharp()"  runat="server" Text="Profundidad" CssClass="btn btn-info" OnClick="Boton_Busqueda_Enunciado_Profundidad_Click"/></div>
                    <div class="col-xs-4"><asp:Button ID="Boton_Busqueda_En_Enunciado_Limpio_Porcentaje_Movil" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Porcentaje" CssClass="btn btn-primary" OnClick="Boton_Busqueda_En_Enunciado_Limpio_Porcentaje_Click"/></div>
               
                </div>
            </div>
            
            <div class="row">
                <div class="well" style="margin-top:5px">
                    <div class="col-xs-4 hidden-xs"><asp:Button ID="Boton_Busqueda_En_Enunciado_Limpio_Palabras_Claves" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Buscar x Palabras Claves" CssClass="btn btn-info" OnClick="Boton_Busqueda_En_Enunciado_Limpio_Palabras_Claves_Click" /></div>
                    <div class="col-xs-4 visible-xs"><asp:Button ID="Boton_Busqueda_En_Enunciado_Limpio_Palabras_Claves_Movil" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Claves" CssClass="btn btn-info" OnClick="Boton_Busqueda_En_Enunciado_Limpio_Palabras_Claves_Click" /></div>
                    <div class="col-xs-4 tipo_de_institucion"><asp:DropDownList ID="DropDownList_Tipo_De_Institucion" runat="server" >
                            <asp:ListItem Value="1">Secundario</asp:ListItem>
                            <asp:ListItem Value="2">Ciclo Medio</asp:ListItem>
                            <asp:ListItem Value="3">Ciclo Superior</asp:ListItem>
                            <asp:ListItem Value="4">Terceario</asp:ListItem>
                            <asp:ListItem Value="5">Universidad</asp:ListItem>
                            <asp:ListItem Value="6">Varios</asp:ListItem>
                            <asp:ListItem Value="7">Ciclo Inicial</asp:ListItem>
                            <asp:ListItem Value="8">Ingreso Universidad</asp:ListItem>
                            <asp:ListItem Value="9">Ingreso Secundario</asp:ListItem>
                            <asp:ListItem Value="10">Ingreso Terceario</asp:ListItem>
                        </asp:DropDownList></div>
                    <div class="col-xs-4 buscar_x_institucion hidden-xs"><asp:Button ID="Boton_Busqueda_Por_Institucion" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Buscar x Institución" CssClass="btn btn-default"  OnClick="Boton_Busqueda_Por_Institucion_Click"/></div>
                    <div class="col-xs-4 visible-xs"><asp:Button ID="Boton_Busqueda_Por_Institucion_Movil" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Institución" CssClass="btn btn-default"  OnClick="Boton_Busqueda_Por_Institucion_Click"/></div>
                </div>

            </div>
            
                
             <div class="row ">
                <div class="well" style="margin-top:5px">
                    <div class="col-xs-3 col-sm-2 tema"><asp:TextBox ID="TextBox_Por_Tema"  runat="server"  ></asp:TextBox></div>
                    <div class="col-xs-3 col-sm-2"><asp:Button ID="Boton_Busqueda_Por_Tema" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Tema"  CssClass="btn btn-success" OnClick="Boton_Busqueda_Por_Tema_Click" /></div>
                    <div class="col-xs-3 col-sm-2 materia"><asp:TextBox ID="TextBox_Por_Materia"   runat="server"></asp:TextBox></div>
                    <div class="col-xs-3 col-sm-2 "><asp:Button ID="Boton_Busqueda_Por_Materia" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Materia"  CssClass="btn btn-success" OnClick="Boton_Busqueda_Por_Materia_Click" /></div>
                    <div class="col-sm-2 x_colegio hidden-xs"><asp:TextBox ID="TextBox_Por_Colegio"  runat="server"  ></asp:TextBox></div>
                    <div class="col-sm-2 hidden-xs"><asp:Button ID="Boton_Busqueda_Por_Colegio" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Colegio" CssClass="btn btn-success" OnClick="Boton_Busqueda_Por_Colegio_Click" /></div>
                    

                </div>
             </div>   


        <div class="row visible-xs">
            <div class="well" style="margin-top:5px">
                    <div class="col-xs-3 colegio_movil"><asp:TextBox ID="TextBox_Por_Colegio_Movil"  runat="server"  ></asp:TextBox></div>
                    <div class="col-xs-3 "><asp:Button ID="Boton_Busqueda_Por_Colegio_Movil" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Cole" CssClass="btn btn-success" OnClick="Boton_Busqueda_Por_Colegio_Click" /></div>
                    <div class="col-xs-3 profesor_movil"><asp:TextBox ID="TextBox_Por_Profesor_Movil" runat="server"  ></asp:TextBox></div>
                    <div class="col-xs-3 "><asp:Button ID="Boton_Busqueda_Por_Profesor_Movil" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Profe"  CssClass="btn btn-success" OnClick="Boton_Busqueda_Por_Profesor_Click" /></div>
                    
            </div>
        </div>

        <div class="row visible-xs">
            <div class="well" style="margin-top:5px">
                    <div class="col-xs-3 ano"><asp:TextBox ID="TextBox_Por_Ano_Movil" runat="server" ></asp:TextBox></div>
                    <div class="col-xs-3"><asp:Button ID="Boton_Busqueda_Por_Ano_Movil" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Año" CssClass="btn btn-success" OnClick="Boton_Busqueda_Por_Ano_Click"  /></div>
                    <div class="col-xs-3 "><asp:Button ID="Boton_Buscar_x_Ficha_Movil" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Ficha"  CssClass="btn btn-warning" OnClick="Button11_Click" /></div>
                    <div class="col-xs-3 "><asp:Button ID="Boton_Buscar_x_Video_Movil" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Vídeo"  CssClass="btn btn-primary" OnClick="Boton_Buscar_x_VIdeo_Click"  /></div>
            </div>
        </div>

                
              <div class="row hidden-xs">
                <div class="well" style="margin-top:5px">
                    <div class="col-sm-2 x_profesor hidden-xs"><asp:TextBox ID="TextBox_Por_Profesor" runat="server"  ></asp:TextBox></div>
                    <div class="col-sm-2 hidden-xs"><asp:Button ID="Boton_Busqueda_Por_Profesor" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Profesor"  CssClass="btn btn-success" OnClick="Boton_Busqueda_Por_Profesor_Click" /></div>
                    <div class="col-sm-2 ano"><asp:TextBox ID="TextBox_Por_Ano" runat="server" ></asp:TextBox></div>
                    <div class="col-sm-2"><asp:Button ID="Boton_Busqueda_Por_Ano" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Año" CssClass="btn btn-success" OnClick="Boton_Busqueda_Por_Ano_Click"  /></div>
                    <div class="col-sm-2 hidden-xs"><asp:Button ID="Boton_Buscar_x_Ficha" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Buscar x Ficha"  CssClass="btn btn-warning" OnClick="Button11_Click" /></div>
                    <div class="col-sm-2 hidden-xs "><asp:Button ID="Boton_Buscar_x_Video" OnClientClick="Cargar_Variable_CSharp()" runat="server" Text="Buscar Vídeo"  CssClass="btn btn-primary" OnClick="Boton_Buscar_x_VIdeo_Click"  /></div>

                </div>
              </div>           
      </div>    
      <hr />    
			             
                    <footer>
                        <div class=" container">
                            <div class="row">
                                <div class="col-xs-12">
                                    <h6>Copyrigth®2015 - Webmaster Martina Ivana Romero</h6>
                                </div>
                                <div class="col-xs-6"></div>
                            </div>
                        </div>
                    </footer>
                

<!-- script references -->
<script src="//ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
<script src="js/scripts.js"></script>


        
    </form>
</body>
</html>

