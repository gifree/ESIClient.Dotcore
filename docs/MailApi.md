# IO.Swagger.Api.MailApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCharactersCharacterIdMailLabelsLabelId**](MailApi.md#deletecharacterscharacteridmaillabelslabelid) | **DELETE** /v1/characters/{character_id}/mail/labels/{label_id}/ | Delete a mail label
[**DeleteCharactersCharacterIdMailMailId**](MailApi.md#deletecharacterscharacteridmailmailid) | **DELETE** /v1/characters/{character_id}/mail/{mail_id}/ | Delete a mail
[**GetCharactersCharacterIdMail**](MailApi.md#getcharacterscharacteridmail) | **GET** /v1/characters/{character_id}/mail/ | Return mail headers
[**GetCharactersCharacterIdMailLabels**](MailApi.md#getcharacterscharacteridmaillabels) | **GET** /v3/characters/{character_id}/mail/labels/ | Get mail labels and unread counts
[**GetCharactersCharacterIdMailLists**](MailApi.md#getcharacterscharacteridmaillists) | **GET** /v1/characters/{character_id}/mail/lists/ | Return mailing list subscriptions
[**GetCharactersCharacterIdMailMailId**](MailApi.md#getcharacterscharacteridmailmailid) | **GET** /v1/characters/{character_id}/mail/{mail_id}/ | Return a mail
[**PostCharactersCharacterIdMail**](MailApi.md#postcharacterscharacteridmail) | **POST** /v1/characters/{character_id}/mail/ | Send a new mail
[**PostCharactersCharacterIdMailLabels**](MailApi.md#postcharacterscharacteridmaillabels) | **POST** /v2/characters/{character_id}/mail/labels/ | Create a mail label
[**PutCharactersCharacterIdMailMailId**](MailApi.md#putcharacterscharacteridmailmailid) | **PUT** /v1/characters/{character_id}/mail/{mail_id}/ | Update metadata about a mail


<a name="deletecharacterscharacteridmaillabelslabelid"></a>
# **DeleteCharactersCharacterIdMailLabelsLabelId**
> void DeleteCharactersCharacterIdMailLabelsLabelId (int? characterId, int? labelId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Delete a mail label

Delete a mail label  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCharactersCharacterIdMailLabelsLabelIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MailApi();
            var characterId = 56;  // int? | An EVE character ID
            var labelId = 56;  // int? | An EVE label id
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Delete a mail label
                apiInstance.DeleteCharactersCharacterIdMailLabelsLabelId(characterId, labelId, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailApi.DeleteCharactersCharacterIdMailLabelsLabelId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **labelId** | **int?**| An EVE label id | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecharacterscharacteridmailmailid"></a>
# **DeleteCharactersCharacterIdMailMailId**
> void DeleteCharactersCharacterIdMailMailId (int? characterId, int? mailId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Delete a mail

Delete a mail  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCharactersCharacterIdMailMailIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MailApi();
            var characterId = 56;  // int? | An EVE character ID
            var mailId = 56;  // int? | An EVE mail ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Delete a mail
                apiInstance.DeleteCharactersCharacterIdMailMailId(characterId, mailId, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailApi.DeleteCharactersCharacterIdMailMailId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **mailId** | **int?**| An EVE mail ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridmail"></a>
# **GetCharactersCharacterIdMail**
> List<GetCharactersCharacterIdMail200Ok> GetCharactersCharacterIdMail (int? characterId, string datasource = null, List<long?> labels = null, int? lastMailId = null, string token = null, string userAgent = null, string xUserAgent = null)

Return mail headers

Return the 50 most recent mail headers belonging to the character that match the query criteria. Queries can be filtered by label, and last_mail_id can be used to paginate backwards.  - --  This route is cached for up to 30 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdMailExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MailApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var labels = new List<long?>(); // List<long?> | Fetch only mails that match one or more of the given labels (optional) 
            var lastMailId = 56;  // int? | List only mail with an ID lower than the given ID, if present (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Return mail headers
                List&lt;GetCharactersCharacterIdMail200Ok&gt; result = apiInstance.GetCharactersCharacterIdMail(characterId, datasource, labels, lastMailId, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailApi.GetCharactersCharacterIdMail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **labels** | [**List&lt;long?&gt;**](long?.md)| Fetch only mails that match one or more of the given labels | [optional] 
 **lastMailId** | **int?**| List only mail with an ID lower than the given ID, if present | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCharactersCharacterIdMail200Ok>**](GetCharactersCharacterIdMail200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridmaillabels"></a>
# **GetCharactersCharacterIdMailLabels**
> GetCharactersCharacterIdMailLabelsOk GetCharactersCharacterIdMailLabels (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get mail labels and unread counts

Return a list of the users mail labels, unread counts for each label and a total unread count.  - --  This route is cached for up to 30 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdMailLabelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MailApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get mail labels and unread counts
                GetCharactersCharacterIdMailLabelsOk result = apiInstance.GetCharactersCharacterIdMailLabels(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailApi.GetCharactersCharacterIdMailLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetCharactersCharacterIdMailLabelsOk**](GetCharactersCharacterIdMailLabelsOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridmaillists"></a>
# **GetCharactersCharacterIdMailLists**
> List<GetCharactersCharacterIdMailLists200Ok> GetCharactersCharacterIdMailLists (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Return mailing list subscriptions

Return all mailing lists that the character is subscribed to  - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdMailListsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MailApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Return mailing list subscriptions
                List&lt;GetCharactersCharacterIdMailLists200Ok&gt; result = apiInstance.GetCharactersCharacterIdMailLists(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailApi.GetCharactersCharacterIdMailLists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCharactersCharacterIdMailLists200Ok>**](GetCharactersCharacterIdMailLists200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridmailmailid"></a>
# **GetCharactersCharacterIdMailMailId**
> GetCharactersCharacterIdMailMailIdOk GetCharactersCharacterIdMailMailId (int? characterId, int? mailId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Return a mail

Return the contents of an EVE mail  - --  This route is cached for up to 30 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdMailMailIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MailApi();
            var characterId = 56;  // int? | An EVE character ID
            var mailId = 56;  // int? | An EVE mail ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Return a mail
                GetCharactersCharacterIdMailMailIdOk result = apiInstance.GetCharactersCharacterIdMailMailId(characterId, mailId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailApi.GetCharactersCharacterIdMailMailId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **mailId** | **int?**| An EVE mail ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetCharactersCharacterIdMailMailIdOk**](GetCharactersCharacterIdMailMailIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridmail"></a>
# **PostCharactersCharacterIdMail**
> int? PostCharactersCharacterIdMail (int? characterId, PostCharactersCharacterIdMailMail mail, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Send a new mail

Create and send a new mail  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCharactersCharacterIdMailExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MailApi();
            var characterId = 56;  // int? | An EVE character ID
            var mail = new PostCharactersCharacterIdMailMail(); // PostCharactersCharacterIdMailMail | The mail to send
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Send a new mail
                int? result = apiInstance.PostCharactersCharacterIdMail(characterId, mail, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailApi.PostCharactersCharacterIdMail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **mail** | [**PostCharactersCharacterIdMailMail**](PostCharactersCharacterIdMailMail.md)| The mail to send | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**int?**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridmaillabels"></a>
# **PostCharactersCharacterIdMailLabels**
> long? PostCharactersCharacterIdMailLabels (int? characterId, string datasource = null, PostCharactersCharacterIdMailLabelsLabel label = null, string token = null, string userAgent = null, string xUserAgent = null)

Create a mail label

Create a mail label  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCharactersCharacterIdMailLabelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MailApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var label = new PostCharactersCharacterIdMailLabelsLabel(); // PostCharactersCharacterIdMailLabelsLabel | Label to create (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Create a mail label
                long? result = apiInstance.PostCharactersCharacterIdMailLabels(characterId, datasource, label, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailApi.PostCharactersCharacterIdMailLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **label** | [**PostCharactersCharacterIdMailLabelsLabel**](PostCharactersCharacterIdMailLabelsLabel.md)| Label to create | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**long?**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcharacterscharacteridmailmailid"></a>
# **PutCharactersCharacterIdMailMailId**
> void PutCharactersCharacterIdMailMailId (int? characterId, PutCharactersCharacterIdMailMailIdContents contents, int? mailId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Update metadata about a mail

Update metadata about a mail  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutCharactersCharacterIdMailMailIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MailApi();
            var characterId = 56;  // int? | An EVE character ID
            var contents = new PutCharactersCharacterIdMailMailIdContents(); // PutCharactersCharacterIdMailMailIdContents | Data used to update the mail
            var mailId = 56;  // int? | An EVE mail ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Update metadata about a mail
                apiInstance.PutCharactersCharacterIdMailMailId(characterId, contents, mailId, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailApi.PutCharactersCharacterIdMailMailId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **contents** | [**PutCharactersCharacterIdMailMailIdContents**](PutCharactersCharacterIdMailMailIdContents.md)| Data used to update the mail | 
 **mailId** | **int?**| An EVE mail ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
