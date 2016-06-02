"# CurrencyConvertor" 

Functional Requirements
The local regional bank needs a web page developed for converting currencies. They currently generate an XML file from their Foreign exchange system. To keep costs down, they would like to use that as the data source for exchange rates. The file can be updated multiple times per day and results on the web page need to be up to date as quickly as possible.

The web page should contain 3 editable fields, one to select the From currency, one for the To currency and one for the user to enter the amount to be converted. The page should communicate with the server asynchronously to convert the amount between currencies (the page should not be reloaded when the user requests a currency to be converted). Currency exchange rates should be read from the supplied file (Currencies.xml). All exchange rates are in US Dollars.

Technical Requirements
The application can be written in .net MVC 4 or higher. The use of any javascript frameworks or technologies are acceptable, however we have a preference for Angular, React, JQuery or Knockout.

