# Dragonfly.ActiveCampaignV3Api TO-DO LIST #

This list is based on the [ActiveCampaign API Documentation](https://developers.activecampaign.com/reference).

## How to Understand this Document ##
The 'Features' section lists all the API functions available, with links to the AC documentation for each. For in-progress models, the features are organized, with references to the 'Request' implementation code files which have been set up. 

Icons and notes explain the current status of each feature:
- ✔ = The implementation is complete
- 🛠 = Implementation in progress
- ⚠ = Some issues need to be resolved (most likely due to not having enough functionality in my account for testing)

## Features ##

### Accounts

- [Accounts](https://developers.activecampaign.com/reference#accounts)
	- Queries: *\Queries\Accounts\AccountRequest.cs*
		- ⚠ [get : Retrieve an account](https://developers.activecampaign.com/reference#retrieve-an-account) {Need AccountsList model example}
		- ⚠ [get : List all accounts](https://developers.activecampaign.com/reference#list-all-accounts) {Need AccountsList model example}
	- Commands:
		- [post : Create an  account](https://developers.activecampaign.com/reference#create-an-account-new)
		- [put : Update an  account](https://developers.activecampaign.com/reference#update-an-account-new)
		- [delete : Delete an  account](https://developers.activecampaign.com/reference#delete-an-account)
		- [post : Create an account note](https://developers.activecampaign.com/reference#create-an-account-note)
		- [put : Update an account note](https://developers.activecampaign.com/reference#update-a-account-note)
		- [delete : Bulk delete accounts](https://developers.activecampaign.com/reference#bulk-delete-accounts)
- [Account Contact Association](https://developers.activecampaign.com/reference#account-contacts)
	- Queries: *\Queries\Accounts\AccountContactRequest.cs*
		- ⚠ [get : Retrieve an association](https://developers.activecampaign.com/reference#retrieve-an-association) {Need AccountContactsList model example}
		- ⚠ [get : List all associations](https://developers.activecampaign.com/reference#list-all-associations-1) {Need AccountContactsList model example}
	- Commands:
		- [post : Create an association](https://developers.activecampaign.com/reference#create-an-account-1)
		- [put : Update an association](https://developers.activecampaign.com/reference#update-an-association-1)
		- [delete : Delete an association](https://developers.activecampaign.com/reference#delete-an-association-1)
- [Custom Account Fields](https://developers.activecampaign.com/reference#custom-account-fields-1)
	- Queries: *\Queries\Accounts\AccountCustomFieldRequest.cs*
		- ⚠ [get : List all custom fields](https://developers.activecampaign.com/reference#list-all-custom-fields) {Need AccountCustomFieldMetaList model example}
		- ⚠ [get : Retrieve a custom field](https://developers.activecampaign.com/reference#retrieve-a-custom-field) {Need AccountCustomFieldMetaList model example}
	- Commands:
		- [post : Create a custom field](https://developers.activecampaign.com/reference#create-a-custom-field)
		- [put : Update a custom field](https://developers.activecampaign.com/reference#update-a-custom-field)
		- [delete : Delete a custom field](https://developers.activecampaign.com/reference#delete-a-custom-field)
- [Custom Account Field Values](https://developers.activecampaign.com/reference#custom-account-field-values)
	- Queries: *\Queries\Accounts\AccountCustomFieldDataRequest.cs*
		- ⚠ [get : List all custom field values](https://developers.activecampaign.com/reference#list-all-custom-field-values-2) {Need AccountCustomFieldDataList model example}
		- ⚠ [get : Retrieve a custom field value](https://developers.activecampaign.com/reference#retrieve-a-custom-field-value) {Need AccountCustomFieldDataList model example}
	- Commands:
		- [post : Create a custom field value](https://developers.activecampaign.com/reference#create-a-custom-field-value-1)
		- [post : Bulk create a custom field value](https://developers.activecampaign.com/reference#bulk-create-a-custom-field-value-1)
		- [put : Update a custom field value](https://developers.activecampaign.com/reference#update-a-custom-field-value)
		- [delete : Delete a custom field value](https://developers.activecampaign.com/reference#delete-a-custom-field-value)
		- [patch : Bulk update a custom field value](https://developers.activecampaign.com/reference#bulk-update-a-custom-field-value-1)

### Addresses

- [Addresses](https://developers.activecampaign.com/reference#address)
	- Queries:* \Queries\Addresses\AddressRequest.cs*
		- 🛠 [get : Retrieve an address](https://developers.activecampaign.com/reference#retrieve-an-address)
		- 🛠 [get : List all addresses](https://developers.activecampaign.com/reference#list-all-addresses)
	- Commands:
		- [post : Create an address](https://developers.activecampaign.com/reference#testinput)
		- [put : Update an address](https://developers.activecampaign.com/reference#update-an-address-2)
		- [delete : Delete an address](https://developers.activecampaign.com/reference#delete-an-address)
		- [delete : Delete address associated with a specific user group](https://developers.activecampaign.com/reference#delete-an-addressgroup)
		- [delete : Delete address associated with a specific list](https://developers.activecampaign.com/reference#delete-an-addresslist)

### Automations

- [Automations](https://developers.activecampaign.com/reference#automation)
	- Queries: *\Queries\Automations\AutomationRequest.cs*
		-🛠 [get : List all automations](https://developers.activecampaign.com/reference#list-all-automations)

### Branding

- [Branding](https://developers.activecampaign.com/reference#branding)
	- Queries: *\Queries\Branding\BrandingRequest.cs*
		- ⚠ [get : List all brandings](https://developers.activecampaign.com/reference#brandings) {Need BrandingList model example}
		- ⚠ [get : Retrieve a branding](https://developers.activecampaign.com/reference#get-branding) {Need BrandingList model example}
	- Commands:
		- [put : Update a branding](https://developers.activecampaign.com/reference#update-branding)

### Calendar Feeds

- [Calendar Feeds](https://developers.activecampaign.com/reference#calendar-feeds)
	- Queries: *\Queries\CalendarFeeds\CalendarFeedsRequest.cs*
		- ⚠ [get : List all calendar feeds](https://developers.activecampaign.com/reference#list-all-calendar-feeds) {Need CalendarFeedsList model example}
		- ⚠ [get : Retrieve a calendar feed](https://developers.activecampaign.com/reference#list-all-calendar-feeds-1) {Need CalendarFeedsList model example}
	- Commands:
		- [post : Create a calendar feed](https://developers.activecampaign.com/reference#create-a-calendar-feed)
		- [put : Update a calendar feed](https://developers.activecampaign.com/reference#update-a-calendar-feed)
		- [delete : Delete a calendar feed](https://developers.activecampaign.com/reference#remove-a-calendar-feed)


### Campaigns

- [Campaigns](https://developers.activecampaign.com/reference#test-1)
	- Queries: \Queries\
		- [get : List all campaigns](https://developers.activecampaign.com/reference#list-all-campaigns)
		- [get : Retrieve links associated to campaign](https://developers.activecampaign.com/reference#retrieve-links-associated-campaign)
		- [get : Retrieve a campaign](https://developers.activecampaign.com/reference#retrieve-a-campaign)
- [Messages](https://developers.activecampaign.com/reference#messages)
	- Queries: \Queries\
		- [get : Retrieve a message](https://developers.activecampaign.com/reference#retrieve-a-message)
		- [get : List all messages](https://developers.activecampaign.com/reference#list-all-messages)
	- Commands:
		- [post : Create a message](https://developers.activecampaign.com/reference#create-a-new-message)
		- [put : Update a message](https://developers.activecampaign.com/reference#update-a-message)
		- [delete : Delete a message](https://developers.activecampaign.com/reference#delete-a-message)


### Contacts

- [Contacts](https://developers.activecampaign.com/reference#contact)
	- Queries: \Queries\Contacts\
		- ✔ [get : Retrieve a contact](https://developers.activecampaign.com/reference#get-contact) (ContactRequest.cs)
		- 🛠 [get : List all contacts](https://developers.activecampaign.com/reference#list-all-contacts) (ContactRequest.cs) {Needs pagination and sorting support}
		- [get : List all automations the contact is in](https://developers.activecampaign.com/reference#list-all-contactautomations-for-contact)
		- [get : Retrieve a contacts score value](https://developers.activecampaign.com/reference#retrieve-a-contacts-score-value)
	- Commands: 
		- [post : Create a contact](https://developers.activecampaign.com/reference#create-a-contact-new)
		- [post : Create or update contact](https://developers.activecampaign.com/reference#create-or-update-contact-new)
		- [post : Update list status for a contact](https://developers.activecampaign.com/reference#update-list-status-for-contact)
		- [put : Update a contact](https://developers.activecampaign.com/reference#update-a-contact-new)
		- [delete : Delete a contact](https://developers.activecampaign.com/reference#delete-contact)
		- [post : Bulk import contacts](https://developers.activecampaign.com/reference#bulk-import-contacts)
- [Automations](https://developers.activecampaign.com/reference#automations)
	- Queries: \Queries\
		- [get : Retrieve an automation a contact is in](https://developers.activecampaign.com/reference#retrieve-a-contactautomation)
		- [get : List all automations a contact is in](https://developers.activecampaign.com/reference#list-all-contact-automations)
	- Commands:
		- [post : Add a contact to an automation](https://developers.activecampaign.com/reference#create-new-contactautomation)
		- [delete : Remove a contact from an automation](https://developers.activecampaign.com/reference#delete-a-contactautomation)
- [Custom Fields](https://developers.activecampaign.com/reference#fields)
	- Queries: \Queries\CustomFields\CustomFieldRequest.cs
		- ✔ [get : Retrieve a custom field](https://developers.activecampaign.com/reference#retrieve-a-field)
		- ✔ [get : List all custom fields](https://developers.activecampaign.com/reference#retrieve-fields-1)
	- Commands:
		- [post : Create a custom field](https://developers.activecampaign.com/reference#retrieve-fields)
		- [put : Update a custom field](https://developers.activecampaign.com/reference#update-a-field)
		- [delete : Delete a custom field](https://developers.activecampaign.com/reference#delete-a-field)
		- [post : Create a custom field relationship to list(s)](https://developers.activecampaign.com/reference#create-a-custom-field-relationship-to-lists)
		- [post : Create custom field options](https://developers.activecampaign.com/reference#create-custom-field-options)
- [Custom Field Values](https://developers.activecampaign.com/reference#fieldvalues)
	- Queries: \Queries\
 		- [get : Retrieve a custom field value](https://developers.activecampaign.com/reference#retrieve-a-fieldvalues)
 		- [get : List all custom field values](https://developers.activecampaign.com/reference#list-all-custom-field-values-1)
	- Commands:
		- [post : Create a custom field value](https://developers.activecampaign.com/reference#create-fieldvalue)
		- [put : Update a custom field value for contact](https://developers.activecampaign.com/reference#update-a-custom-field-value-for-contact)
		- [delete : Delete a custom field value](https://developers.activecampaign.com/reference#delete-a-fieldvalue-1)
- [Email (emailActivities)](https://developers.activecampaign.com/reference#email-emailactivities)
	- Queries: \Queries\
		- [get : List all email activities](https://developers.activecampaign.com/reference#list-all-email-activities)
- [Tags](https://developers.activecampaign.com/reference#contact-tags)
	- Commands:
		- [post : Add a tag to contact](https://developers.activecampaign.com/reference#create-contact-tag)
		- [delete : Remove a tag from a contact](https://developers.activecampaign.com/reference#delete-contact-tag)

### Deals

- [Deals](https://developers.activecampaign.com/reference#deal)
	- Queries: \Queries\
		- [get : Retrieve a deal](https://developers.activecampaign.com/reference#retrieve-a-deal)
		- [get : List all deals](https://developers.activecampaign.com/reference#list-all-deals)
	- Commands:
		- [post : Create a deal](https://developers.activecampaign.com/reference#create-a-deal-new)
		- [put : Update a deal](https://developers.activecampaign.com/reference#update-a-deal-new)
		- [delete : Delete a deal](https://developers.activecampaign.com/reference#delete-a-deal)
		- [post : Create a deal note](https://developers.activecampaign.com/reference#create-a-deal-note)
		- [put : Update a deal note](https://developers.activecampaign.com/reference#update-a-deal-note)
- [Pipelines](https://developers.activecampaign.com/reference#pipelines)
	- Queries: \Queries\
		- [get : Retrieve a pipeline](https://developers.activecampaign.com/reference#retrieve-a-pipeline)
		- [get : List all pipelines](https://developers.activecampaign.com/reference#list-all-pipelines)
	- Commands:
		- [post : Create a pipeline](https://developers.activecampaign.com/reference#create-a-pipeline)
		- [put : Update a pipeline](https://developers.activecampaign.com/reference#update-a-pipeline)
		- [delete : Delete a pipeline](https://developers.activecampaign.com/reference#delete-a-pipeline)
- [Stages](https://developers.activecampaign.com/reference#deal-stages)
	- Queries: \Queries\
		- [get : Retrieve a stage](https://developers.activecampaign.com/reference#retrieve-a-deal-stage)
		- [get : List all stages](https://developers.activecampaign.com/reference#list-all-deal-stages)
	- Commands:
		- [post : Create a stage](https://developers.activecampaign.com/reference#create-a-deal-stage)
		- [put : Update a stage](https://developers.activecampaign.com/reference#update-a-deal-stage)
		- [delete : Delete a stage](https://developers.activecampaign.com/reference#delete-a-deal-stage)
		- [put : Move deals to another stage](https://developers.activecampaign.com/reference#move-deals-to-another-deal-stage)
- [Custom Deal Fields](https://developers.activecampaign.com/reference#dealcustomfieldmeta)
	- Queries: \Queries\
		- [get : Retrieve a custom field](https://developers.activecampaign.com/reference#retrieve-a-dealcustomfieldmeta-resource)
		- [get : List all custom fields](https://developers.activecampaign.com/reference#retrieve-all-dealcustomfielddata-resources)
	- Commands:
		- [post : Create a custom field](https://developers.activecampaign.com/reference#create-dealcustomfieldmeta-resources)
		- [put : Update a custom field](https://developers.activecampaign.com/reference#update-a-dealcustomfieldmeta)
		- [delete : Delete a custom field](https://developers.activecampaign.com/reference#delete-a-dealcustomfieldmeta-resource)
- [Custom Deal Field Values](https://developers.activecampaign.com/reference#dealcustomfielddata)
	- Queries: \Queries\
		- [get : Retrieve a custom field value](https://developers.activecampaign.com/reference#retrieve-a-dealcustomfielddata)
		- [get : List all custom field values](https://developers.activecampaign.com/reference#list-all-custom-field-values)
	- Commands:
		- [post : Create a custom field value](https://developers.activecampaign.com/reference#create-dealcustomfielddata-resource)
		- [post : Bulk create a custom field value](https://developers.activecampaign.com/reference#bulk-create-a-custom-field-value)
		- [put : Update a custom field value](https://developers.activecampaign.com/reference#update-a-dealcustomfielddata-resource)
		- [patch : Bulk update a custom field value](https://developers.activecampaign.com/reference#bulk-update-a-custom-field-value)
		- [delete : Delete a custom field value](https://developers.activecampaign.com/reference#retrieve-a-dealcustomfielddata-resource)
- [Secondary Contacts](https://developers.activecampaign.com/reference#secondary-contacts)
	- Queries: \Queries\
		- [get : Retrieve a secondary contact](https://developers.activecampaign.com/reference#retrieve-a-secondary-contact)
		- [get : List all secondary contacts](https://developers.activecampaign.com/reference#list-all-secondary-contacts)
	- Commands:
		- [post : Create a secondary contact](https://developers.activecampaign.com/reference#create-a-secondary-contact)
		- [put : Update a secondary contact](https://developers.activecampaign.com/reference#update-a-secondary-contact)
		- [delete : Delete a secondary contact](https://developers.activecampaign.com/reference#delete-a-secondary-contact)

### DeepData Integrations

- [Connections](https://developers.activecampaign.com/reference#connections)
	- Queries: \Queries\
		- [get : Retrieve a connection](https://developers.activecampaign.com/reference#get-connection)
		- [get : List all connections](https://developers.activecampaign.com/reference#list-all-connections)
	- Commands:
		- [post : Create a connection](https://developers.activecampaign.com/reference#create-connection)
		- [put : Update a connection](https://developers.activecampaign.com/reference#update-connection)
		- [delete : Delete a connection](https://developers.activecampaign.com/reference#delete-connection)
- [E-Commerce Customers](https://developers.activecampaign.com/reference#customers)
	- Queries: \Queries\
		- [get : Retrieve a customer](https://developers.activecampaign.com/reference#get-customer)
		- [get : List all customers](https://developers.activecampaign.com/reference#list-all-customers)
	- Commands:
		- [post : Create a customer](https://developers.activecampaign.com/reference#create-customer)
		- [put : Update a customer](https://developers.activecampaign.com/reference#update-customer)
		- [delete : Delete a customer](https://developers.activecampaign.com/reference#delete-customer)
- [E-Commerce Orders](https://developers.activecampaign.com/reference#orders)
	- Queries: \Queries\
		- [get : List all orders](https://developers.activecampaign.com/reference#list-all-orders)
		- [get : Retrieve an order](https://developers.activecampaign.com/reference#get-order)
	- Commands:
		- [post : Create an order](https://developers.activecampaign.com/reference#create-order)
		- [delete : Delete an order](https://developers.activecampaign.com/reference#delete-order)
		- [put : Update an order](https://developers.activecampaign.com/reference#update-order)
- [E-Commerce Abandoned Carts](https://developers.activecampaign.com/reference#e-commerce-abandoned-carts)
- [E-Commerce Order Products](https://developers.activecampaign.com/reference#e-commerce-order-products)
	- Queries: \Queries\
		- [get : List EcomOrderProducts](https://developers.activecampaign.com/reference#list-ecomorderproducts)
		- [get : List EcomOrderProducts for a Specific EcomOrder](https://developers.activecampaign.com/reference#list-products-for-order)
		- [get : Retrieve an EcomOrderProduct](https://developers.activecampaign.com/reference#retrieve-an-ecomorderproduct)

### Forms

- [Forms](https://developers.activecampaign.com/reference#forms)
	- Queries: \Queries\
		- [get : Retrieve a form](https://developers.activecampaign.com/reference#retrieve-forms)
		- [get : List all forms](https://developers.activecampaign.com/reference#forms-1)

### Lists

- [Lists](https://developers.activecampaign.com/reference#lists)
	- Queries: \Queries\
		- [get : Retrieve a list](https://developers.activecampaign.com/reference#retrieve-a-list)
		- [get : Retrieve all lists](https://developers.activecampaign.com/reference#retrieve-all-lists)
	- Commands:
		- [post : Create a list](https://developers.activecampaign.com/reference#create-new-list)
		- [delete : Delete a list](https://developers.activecampaign.com/reference#delete-a-list)
		- [post : Create a list group permission](https://developers.activecampaign.com/reference#create-a-list-group-permission)

### Notes

- [Notes](https://developers.activecampaign.com/reference#notes)
	- Queries: \Queries\
		- [get : Retrieve a note](https://developers.activecampaign.com/reference#retrieve-a-note)
	- Commands:
		- [post : Create a note](https://developers.activecampaign.com/reference#create-a-note)
		- [put : Update a note](https://developers.activecampaign.com/reference#update-a-note)
		- [delete : Delete a note](https://developers.activecampaign.com/reference#delete-note)

### Organizations (Deprecated)

- [Organizations](https://developers.activecampaign.com/reference#organizations)
	- Queries: \Queries\
		- [get : Retrieve an organization](https://developers.activecampaign.com/reference#get-organization)
		- [get : List all organizations](https://developers.activecampaign.com/reference#list-all-organizations)
	- Commands:
		- [post : Create an organization](https://developers.activecampaign.com/reference#create-organization)
		- [put : Update an organization](https://developers.activecampaign.com/reference#update-organization)
		- [delete : Delete an organization](https://developers.activecampaign.com/reference#delete-organization)
		- [delete : Delete multiple organizations](https://developers.activecampaign.com/reference#delete-multiple-organizations)

### Saved Responses

- [Saved Responses](https://developers.activecampaign.com/reference#saved-responses-1)
	- Queries: \Queries\
		- [get : Retrieve a saved response](https://developers.activecampaign.com/reference#get-a-savedresponse)
		- [get : List all saved responses](https://developers.activecampaign.com/reference#list-all-saved-responses)
	- Commands:
		- [post : Create a saved response](https://developers.activecampaign.com/reference#saved-responses)
		- [put : Update a saved response](https://developers.activecampaign.com/reference#update-a-saved-response)
		- [delete : Delete a saved response](https://developers.activecampaign.com/reference#retrieve-a-savedresponse)

### Scores

- [Scores](https://developers.activecampaign.com/reference#scores)
	- Queries: \Queries\
		- [get : Retrieve a score](https://developers.activecampaign.com/reference#retrieve-a-score)
		- [get : List all scores](https://developers.activecampaign.com/reference#list-all-scores)

### Segments

- [Segments](https://developers.activecampaign.com/reference#segments)
	- Queries: \Queries\
		- [get : Retrieve a segment](https://developers.activecampaign.com/reference#retrieve-a-segment)
		- [get : List all segments](https://developers.activecampaign.com/reference#list-all-segments)

### Settings

- [Settings](https://developers.activecampaign.com/reference#configs)
	- Commands:
		- [put : Update settings](https://developers.activecampaign.com/reference#set-config)

### Site & Event Tracking

- [Event Tracking](https://developers.activecampaign.com/reference#event-tracking)
	- Queries: \Queries\
		- [get : Retrieve status](https://developers.activecampaign.com/reference#retrieve-event-tracking-status)
		- [get : List all events (names only)](https://developers.activecampaign.com/reference#list-all-event-types)
	- Commands:
		- [post : Track event](https://developers.activecampaign.com/reference#track-event)
		- [post : Create a new event (name only)](https://developers.activecampaign.com/reference#create-a-new-event-name-only)
		- [put : Enable/disable](https://developers.activecampaign.com/reference#enable-disable-event-tracking)
		- [delete : Delete event (name only)](https://developers.activecampaign.com/reference#remove-event-name-only)
- [Site Tracking](https://developers.activecampaign.com/reference#site-tracking)
	- Queries: \Queries\
		- [get : Retrieve site tracking code](https://developers.activecampaign.com/reference#retrieve-site-tracking-code)
		- [get : Retrieve status](https://developers.activecampaign.com/reference#retrieve-site-tracking-status)
		- [get : List all whitelisted domains](https://developers.activecampaign.com/reference#list-all-whitelisted-domains)
	- Commands:
		- [post : Add domain to whitelist](https://developers.activecampaign.com/reference#add-domain-to-whitelist)
		- [put : Enable/disable](https://developers.activecampaign.com/reference#enable-disable-site-tracking)
		- [delete : Remove domain from whitelist](https://developers.activecampaign.com/reference#remove-domain-from-whitelist)

### Tags

- [Tags](https://developers.activecampaign.com/reference#tags)
	- Queries: \Queries\
		- [get : Retrieve a tag](https://developers.activecampaign.com/reference#retrieve-a-tag)
		- [get : List all tags](https://developers.activecampaign.com/reference#retrieve-all-tags)
	- Commands:
		- [post : Create a tag](https://developers.activecampaign.com/reference#create-a-new-tag)
		- [put : Update a tag](https://developers.activecampaign.com/reference#update-a-tag)
		- [delete : Delete a tag](https://developers.activecampaign.com/reference#remove-a-tag)

### Tasks

- [Tasks](https://developers.activecampaign.com/reference#tasks)
	- Queries: \Queries\
		- [get : Retrieve a task](https://developers.activecampaign.com/reference#get-task)
		- [get : List all tasks](https://developers.activecampaign.com/reference#list-all-tasks)
	- Commands:
		- [post : Create a task](https://developers.activecampaign.com/reference#create-task)
		- [put : Update a task](https://developers.activecampaign.com/reference#update-task)
		- [delete : Delete a task](https://developers.activecampaign.com/reference#delete-task)

### Task Types

- [Task Types](https://developers.activecampaign.com/reference#deal-task-types)
	- Queries: \Queries\
		- [get : Retrieve a task type](https://developers.activecampaign.com/reference#retrieve-a-deal-task-type)
		- [get : List all task types](https://developers.activecampaign.com/reference#list-all-deal-task-types)
	- Commands:
		- [post : Create a task type](https://developers.activecampaign.com/reference#create-a-deal-task-type)
		- [put : Update a task type](https://developers.activecampaign.com/reference#update-a-deal-task-type)
		- [delete : Delete a task type](https://developers.activecampaign.com/reference#delete-a-deal-task-type)
		- [put : Move tasks to another task type](https://developers.activecampaign.com/reference#move-deal-tasks-to-another-deal-task-type)

### Templates

- [Templates](https://developers.activecampaign.com/reference#templates)
	- Queries: \Queries\
		- [get : Retrieve a template](https://developers.activecampaign.com/reference#retrieve-a-template)

### Users

- [Users](https://developers.activecampaign.com/reference#users)
	- Queries: \Queries\
		- [get : Retrieve a user](https://developers.activecampaign.com/reference#get-user)
		- [get : Retrieve a user by email](https://developers.activecampaign.com/reference#get-user-email)
		- [get : Retrieve a user by username](https://developers.activecampaign.com/reference#get-user-username)
		- [get : Retrieve logged-in user](https://developers.activecampaign.com/reference#get-user-loggedin)
		- [get : List all users](https://developers.activecampaign.com/reference#list-all-users)
	- Commands:
		- [post : Create a user](https://developers.activecampaign.com/reference#create-user)
		- [put : Update a user](https://developers.activecampaign.com/reference#update-user)
		- [delete : Delete a user](https://developers.activecampaign.com/reference#delete-user)
- [Groups](https://developers.activecampaign.com/reference#groups)
	- Queries: \Queries\
		- [get : Retrieve a group](https://developers.activecampaign.com/reference#retrieve-a-group)
		- [get : List all groups](https://developers.activecampaign.com/reference#list-all-groups)
	- Commands:
		- [post : Create a group](https://developers.activecampaign.com/reference#create-a-new-group)
		- [put : Update a group](https://developers.activecampaign.com/reference#update-a-group)
		- [delete : Delete a group](https://developers.activecampaign.com/reference#delete-a-group-1)

### Webhooks

- [Webhooks](https://developers.activecampaign.com/reference#webhooks)
	- Queries: \Queries\
		- [get : Retrieve a webhook](https://developers.activecampaign.com/reference#get-webhook)
		- [get : List all webhooks](https://developers.activecampaign.com/reference#get-a-list-of-webhooks)
		- [get : List all webhook events](https://developers.activecampaign.com/reference#get-a-list-of-webhook-events)
	- Commands: 
		- [post : Create a webhook](https://developers.activecampaign.com/reference#create-webhook)
		- [put : Update a webhook](https://developers.activecampaign.com/reference#update-webhook)
		- [delete : Delete a webhook](https://developers.activecampaign.com/reference#delete-webhook)

- [Working with webhook data](http://www.activecampaign.com/blog/working-with-webhook-data/)
