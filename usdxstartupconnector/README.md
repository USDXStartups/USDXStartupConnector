# US DX Startup Connector

This repo is for the Outlook Group Connector portion of the Startup Bot. Post of the object will create a Outlook Group Item.

**Endpoint** :
http://usdxstartupconnector.azurewebsites.net/api/connector

**Method** :
/CreateCard

**Paramaters** : 
startupcard

     {
         "Name": "string",
         "ContactName": "string",
         "ContactEmail": "string",
         "Category": "string",
         "Inquiry": "string",
         "Location": "string",
         "RequestDate": "2016-12-05T19:07:17.226Z"
     }