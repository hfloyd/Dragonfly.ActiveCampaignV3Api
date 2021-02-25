# Dragonfly.ActiveCampaignV3Api #

A .Net SDK for Version 3 of the ActiveCampaign API created by [Heather Floyd](https://www.HeatherFloyd.com).

## No Warranty ##

The development of this library is not materially supported by ActiveCampaign, and I am not affiliated with ActiveCampaign, except as a customer. You are welcome to use this library, but I provide no warranty on the fitness of this for your purposes, nor for performance, etc. USE THIS IN YOUR PRODUCTION PROJECTS AT YOUR OWN RISK. I welcome pull requests that complete missing functionality and improve the codebase.

## Installation ##

This is currently pre-release and not available on NuGet yet. In order to test the library in your own site, clone and compile, then use the generated .dll in your project.

[![Nuget Downloads](https://buildstats.info/nuget/Dragonfly.Dragonfly.ActiveCampaignV3Api)](https://www.nuget.org/packages/Dragonfly.ActiveCampaign/)

     PM>   Install-Package Dragonfly.ActiveCampaignV3Api

## Features ##

This .Net SDK makes it straight-forward to connect to the AC API to retrieve data and send commands that change data.

**Still to Implement:**
- Some models are missing because I didn't have JSON example data to use from my own account.
- Implementing Query and Command Requests is a time-consuming process, so there are still many API features missing. A full list of the API functions and the associated SDK status is located in the [TODO.md](https://github.com/hfloyd/Dragonfly.ActiveCampaignV3Api/blob/master/TODO.md) file.

## Usage ##

You will need to get your account's "Api Url" and "Api Key" from the **Settings > Developer** area in your ActiveCampaign account. 


### Direct Requests Access ###
Allows for full control over specific requests and returns all information.

Examples:

    //Setup a connection
    var acConn = new ActiveCampaignConnection(apiUrl, apiKey);

	//Setup a ContactRequest
	var reqContact = new ContactRequest(acConn);
    
	//Tell the request to sideload additional data (you can add as many as desired)
	reqContact.IncludeExtraData.Add(ContactsList.LinkedData.Notes);
    reqContact.IncludeExtraData.Add(ContactsList.LinkedData.FieldValues);

	//Get a single contact by Email address
    reqContact.GetSingle("me@domain.com");

	//Extract the Contact object from the result
	var contact = reqContact.Result.ResultData.Contacts.First();
	//NOTE: The "ResultData.Contacts" property is always an IEnumerable, even if your filters would only return one item, thus the use of ".First()"

	//You can set multiple filtering params to get a list of matching contacts
	reqContact.Ids = new List<long>() { 2, 3, 7, 10, 45, 50 };

	//This will use all set filter params
    reqContact.GetList();

	//Extract the various data from the Result
    var contacts = reqContact.Result.ResultData.Contacts;
	var notes = reqContact.Result.ResultData.Notes; 
	//NOTE: If you didn't explicitly sideload additional data (via the .IncludeExtraData option), the property will be NULL.	

	//You can also drill-down into additional data if you don't have it in your initial dataset via sideloading
	(these.'Get...()' methods make addition calls to the AC API)
	var logs = contact.GetBounceLogs(acConn);
	var data = contact.GetContactData(acConn);
	var tags = contact.GetContactTags(acConn);


### ActiveCampaignService ###

Allows for simpler access to common functionality.

Examples:
TBD

## Code Organization ##

Generally, the structure is based on three types of code:

### 1 - AC Object Models ###

The **"Models" folder** includes various subfolders to organize all the individual object models. Most are marked up with with JSON attributes to handle Deserialization from the JSON response data returned by the API. Primarily these are based on various JSON responses directly provided by the API calls. 

The classes in the ApiClient folder are discussed in #2, below.

	
### 2 - AC Connection/Request/Response/Result ###

**2.1 - Models/ApiClient**

Base models for connecting to the AC API, sending a Request, and processing the Response.

**2.2 - Queries**

Specific 'Request' implementations designed to retrieve data and return it cast to the appropriate object model.

**2.3 - Commands**

Specific 'Request' implementations designed to create/edit/delete data.

### 3 - General ###

	1. Extensions
	2. Helpers
	3. Services



## Resources ##

GitHub Repository: [https://github.com/hfloyd/Dragonfly.ActiveCampaignV3Api](https://github.com/hfloyd/Dragonfly.ActiveCampaignV3Api)

[ActiveCampaign API Documentation](https://developers.activecampaign.com/reference)
