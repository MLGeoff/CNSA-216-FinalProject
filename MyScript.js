// JScript File
function CloseMe()
			{
		//close without prompt
			 //var browserName = navigator.appName;
     //var browserVer = parseInt(navigator.appVersion);
     var ie7 = (document.all && !window.opera && window.XMLHttpRequest) ? true : false;  

     if (ie7) 

           {     

           //This method is required to close a window without any prompt for IE7

           window.open('','_parent','');

           window.close();

           }

     else 

           {

           //This method is required to close a window without any prompt for IE6

           this.focus();

           self.opener = this;

           self.close();

           }


			}

  var map = null;
function ContactMe()
    {
    var features = "width=425,height=275,left=50,top=50,status=yes,resizable=no,menubar=no,scrollbars=yes";
    
    map = window.open('./ContactInfo.htm', 'Help',features);
    map.focus()
     
    }
    
function HelpMe()
    {
    var features = "width=350,height=200,left=50,top=50,status=yes,resizable=no,menubar=no,scrollbars=yes";
    
    map = window.open('./Help.htm', 'Help',features);
    map.focus()
     
}

var map = null;
function OpenPage(formMe) {
    var features = "width=425,height=475,left=50,top=50,status=yes,resizable=yes,menubar=no,scrollbars=yes";
    //'./ContactInfo.htm'
    map = window.open(formMe, 'Display', features);
    map.focus()

}
function SelectAll(id) {
    var grid = document.getElementById("<%= grdStudent.ClientID %>");
    var cell;

    if (grid.rows.length > 0) {
        for (i = 1; i < grid.rows.length; i++) {
            cell = grid.rows[i].cells[0];

            for (j = 0; j = cell.childNodes.length; j++) {
                if (cell.childNodes[j].type == "checkbox") {
                    cell.childNodes[j].checked = document.getElementById(id).checked;
                }
            }
        }
    }
}



    