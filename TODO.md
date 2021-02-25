# Dragonfly.ActiveCampaignV3Api TO-DO LIST#

This list is based on the [ActiveCampaign API Documentation](https://developers.activecampaign.com/reference).

## How to Understand this Document ##
The 'Features' section lists all the API functions available, with links to the AC documentation for each. For in-progress models, the features are organized, with references to the 'Request' implementation code files which have been set up. 

Icons and notes explain the current status of each feature:
- ✔ = The implementation is complete
- 🛠 = Implementation in progress
- ⚠ = 

## Features ##

### Accounts

- [Accounts](https://developers.activecampaign.com/reference#accounts)
	- Query: \Queries\Contacts\ContactRequest.cs
		-   ✔ [get : Retrieve an  account](https://developers.activecampaign.com/reference#retrieve-an-account)
		-   [get : List all  accounts](https://developers.activecampaign.com/reference#list-all-accounts)
	- Commands: 
 -   [post : Create an  account](https://developers.activecampaign.com/reference#create-an-account-new)
 -   [put : Update an  account](https://developers.activecampaign.com/reference#update-an-account-new)
 -   [delete : Delete an  account](https://developers.activecampaign.com/reference#delete-an-account)
 -   [post : Create an account note](https://developers.activecampaign.com/reference#create-an-account-note)
 -   [put : Update an account note](https://developers.activecampaign.com/reference#update-a-account-note)
 -   [delete : Bulk delete accounts](https://developers.activecampaign.com/reference#bulk-delete-accounts)
-   [Account Contact Association](https://developers.activecampaign.com/reference#account-contacts)
 -   [post : Create an association](https://developers.activecampaign.com/reference#create-an-account-1)
 -   [get : Retrieve an association](https://developers.activecampaign.com/reference#retrieve-an-association)
 -   [put : Update an association](https://developers.activecampaign.com/reference#update-an-association-1)
 -   [delete : Delete an association](https://developers.activecampaign.com/reference#delete-an-association-1)
 -   [get : List all associations](https://developers.activecampaign.com/reference#list-all-associations-1)
-   [Custom Account Fields](https://developers.activecampaign.com/reference#custom-account-fields-1)
 -   [post : Create a custom field](https://developers.activecampaign.com/reference#create-a-custom-field)
 -   [get : Retrieve a custom field](https://developers.activecampaign.com/reference#retrieve-a-custom-field)
 -   [put : Update a custom field](https://developers.activecampaign.com/reference#update-a-custom-field)
 -   [delete : Delete a custom field](https://developers.activecampaign.com/reference#delete-a-custom-field)
 -   [get : List all custom fields](https://developers.activecampaign.com/reference#list-all-custom-fields)
-   [Custom Account Field Values](https://developers.activecampaign.com/reference#custom-account-field-values)
 -   [post : Create a custom field value](https://developers.activecampaign.com/reference#create-a-custom-field-value-1)
 -   [post : Bulk create a custom field value](https://developers.activecampaign.com/reference#bulk-create-a-custom-field-value-1)
 -   [get : Retrieve a custom field value](https://developers.activecampaign.com/reference#retrieve-a-custom-field-value)
 -   [put : Update a custom field value](https://developers.activecampaign.com/reference#update-a-custom-field-value)
 -   [delete : Delete a custom field value](https://developers.activecampaign.com/reference#delete-a-custom-field-value)
 -   [get : List all custom field values](https://developers.activecampaign.com/reference#list-all-custom-field-values-2)
 -   [patch : Bulk update a custom field value](https://developers.activecampaign.com/reference#bulk-update-a-custom-field-value-1)

### Addresses

-   [Addresses](https://developers.activecampaign.com/reference#address)
 -   [post : Create an address](https://developers.activecampaign.com/reference#testinput)
 -   [get : Retrieve an address](https://developers.activecampaign.com/reference#retrieve-an-address)
 -   [put : Update an address](https://developers.activecampaign.com/reference#update-an-address-2)
 -   [delete : Delete an address](https://developers.activecampaign.com/reference#delete-an-address)
 -   [delete : Delete address associated with a specific user group](https://developers.activecampaign.com/reference#delete-an-addressgroup)
 -   [delete : Delete address associated with a specific list](https://developers.activecampaign.com/reference#delete-an-addresslist)
 -   [get : List all addresses](https://developers.activecampaign.com/reference#list-all-addresses)

### Automations

-   [Automations](https://developers.activecampaign.com/reference#automation)
 -   [get : List all automations](https://developers.activecampaign.com/reference#list-all-automations)

### Branding

-   [Branding](https://developers.activecampaign.com/reference#branding)
 -   [get : Retrieve a branding](https://developers.activecampaign.com/reference#get-branding)
 -   [put : Update a branding](https://developers.activecampaign.com/reference#update-branding)
 -   [get : List all brandings](https://developers.activecampaign.com/reference#brandings)

### Calendar Feeds

-   [Calendar Feeds](https://developers.activecampaign.com/reference#calendar-feeds)
 -   [post : Create a calendar feed](https://developers.activecampaign.com/reference#create-a-calendar-feed)
 -   [get : Retrieve a calendar feed](https://developers.activecampaign.com/reference#list-all-calendar-feeds-1)
 -   [put : Update a calendar feed](https://developers.activecampaign.com/reference#update-a-calendar-feed)
 -   [delete : Delete a calendar feed](https://developers.activecampaign.com/reference#remove-a-calendar-feed)
 -   [get : List all calendar feeds](https://developers.activecampaign.com/reference#list-all-calendar-feeds)

### Campaigns

-   [Campaigns](https://developers.activecampaign.com/reference#test-1)
 -   [get : List all campaigns](https://developers.activecampaign.com/reference#list-all-campaigns)
 -   [get : Retrieve links associated to campaign](https://developers.activecampaign.com/reference#retrieve-links-associated-campaign)
 -   [get : Retrieve a campaign](https://developers.activecampaign.com/reference#retrieve-a-campaign)
-   [Messages](https://developers.activecampaign.com/reference#messages)
 -   [post : Create a message](https://developers.activecampaign.com/reference#create-a-new-message)
 -   [get : Retrieve a message](https://developers.activecampaign.com/reference#retrieve-a-message)
 -   [put : Update a message](https://developers.activecampaign.com/reference#update-a-message)
 -   [delete : Delete a message](https://developers.activecampaign.com/reference#delete-a-message)
 -   [get : List all messages](https://developers.activecampaign.com/reference#list-all-messages)

### Contacts

-   [Contacts](https://developers.activecampaign.com/reference#contact)
 -   [post : Create a contact](https://developers.activecampaign.com/reference#create-a-contact-new)
 -   [post : Create or update contact](https://developers.activecampaign.com/reference#create-or-update-contact-new)
 -   [get : Retrieve a contact](https://developers.activecampaign.com/reference#get-contact)
 -   [post : Update list status for a contact](https://developers.activecampaign.com/reference#update-list-status-for-contact)
 -   [put : Update a contact](https://developers.activecampaign.com/reference#update-a-contact-new)
 -   [delete : Delete a contact](https://developers.activecampaign.com/reference#delete-contact)
 -   [get : List all contacts](https://developers.activecampaign.com/reference#list-all-contacts)
 -   [get : List all automations the contact is in](https://developers.activecampaign.com/reference#list-all-contactautomations-for-contact)
 -   [get : Retrieve a contacts score value](https://developers.activecampaign.com/reference#retrieve-a-contacts-score-value)
 -   [post : Bulk import contacts](https://developers.activecampaign.com/reference#bulk-import-contacts)
-   [Automations](https://developers.activecampaign.com/reference#automations)
 -   [post : Add a contact to an automation](https://developers.activecampaign.com/reference#create-new-contactautomation)
 -   [get : Retrieve an automation a contact is in](https://developers.activecampaign.com/reference#retrieve-a-contactautomation)
 -   [delete : Remove a contact from an automation](https://developers.activecampaign.com/reference#delete-a-contactautomation)
 -   [get : List all automations a contact is in](https://developers.activecampaign.com/reference#list-all-contact-automations)
-   [Custom Fields](https://developers.activecampaign.com/reference#fields)
 -   [post : Create a custom field](https://developers.activecampaign.com/reference#retrieve-fields)
 -   [get : Retrieve a custom field](https://developers.activecampaign.com/reference#retrieve-a-field)
 -   [put : Update a custom field](https://developers.activecampaign.com/reference#update-a-field)
 -   [delete : Delete a custom field](https://developers.activecampaign.com/reference#delete-a-field)
 -   [get : List all custom fields](https://developers.activecampaign.com/reference#retrieve-fields-1)
 -   [post : Create a custom field relationship to list(s)](https://developers.activecampaign.com/reference#create-a-custom-field-relationship-to-lists)
 -   [post : Create custom field options](https://developers.activecampaign.com/reference#create-custom-field-options)
-   [Custom Field Values](https://developers.activecampaign.com/reference#fieldvalues)
 -   [post : Create a custom field value](https://developers.activecampaign.com/reference#create-fieldvalue)
 -   [get : Retrieve a custom field value](https://developers.activecampaign.com/reference#retrieve-a-fieldvalues)
 -   [put : Update a custom field value for contact](https://developers.activecampaign.com/reference#update-a-custom-field-value-for-contact)
 -   [delete : Delete a custom field value](https://developers.activecampaign.com/reference#delete-a-fieldvalue-1)
 -   [get : List all custom field values](https://developers.activecampaign.com/reference#list-all-custom-field-values-1)
-   [Email (emailActivities)](https://developers.activecampaign.com/reference#email-emailactivities)
 -   [get : List all email activities](https://developers.activecampaign.com/reference#list-all-email-activities)
-   [Tags](https://developers.activecampaign.com/reference#contact-tags)
 -   [post : Add a tag to contact](https://developers.activecampaign.com/reference#create-contact-tag)
 -   [delete : Remove a tag from a contact](https://developers.activecampaign.com/reference#delete-contact-tag)

### Deals

-   [Deals](https://developers.activecampaign.com/reference#deal)
 -   [post : Create a deal](https://developers.activecampaign.com/reference#create-a-deal-new)
 -   [get : Retrieve a deal](https://developers.activecampaign.com/reference#retrieve-a-deal)
 -   [put : Update a deal](https://developers.activecampaign.com/reference#update-a-deal-new)
 -   [delete : Delete a deal](https://developers.activecampaign.com/reference#delete-a-deal)
 -   [get : List all deals](https://developers.activecampaign.com/reference#list-all-deals)
 -   [post : Create a deal note](https://developers.activecampaign.com/reference#create-a-deal-note)
 -   [put : Update a deal note](https://developers.activecampaign.com/reference#update-a-deal-note)
-   [Pipelines](https://developers.activecampaign.com/reference#pipelines)
 -   [post : Create a pipeline](https://developers.activecampaign.com/reference#create-a-pipeline)
 -   [get : Retrieve a pipeline](https://developers.activecampaign.com/reference#retrieve-a-pipeline)
 -   [put : Update a pipeline](https://developers.activecampaign.com/reference#update-a-pipeline)
 -   [delete : Delete a pipeline](https://developers.activecampaign.com/reference#delete-a-pipeline)
 -   [get : List all pipelines](https://developers.activecampaign.com/reference#list-all-pipelines)
-   [Stages](https://developers.activecampaign.com/reference#deal-stages)
 -   [post : Create a stage](https://developers.activecampaign.com/reference#create-a-deal-stage)
 -   [get : Retrieve a stage](https://developers.activecampaign.com/reference#retrieve-a-deal-stage)
 -   [put : Update a stage](https://developers.activecampaign.com/reference#update-a-deal-stage)
 -   [delete : Delete a stage](https://developers.activecampaign.com/reference#delete-a-deal-stage)
 -   [get : List all stages](https://developers.activecampaign.com/reference#list-all-deal-stages)
 -   [put : Move deals to another stage](https://developers.activecampaign.com/reference#move-deals-to-another-deal-stage)
-   [Custom Deal Fields](https://developers.activecampaign.com/reference#dealcustomfieldmeta)
 -   [post : Create a custom field](https://developers.activecampaign.com/reference#create-dealcustomfieldmeta-resources)
 -   [get : Retrieve a custom field](https://developers.activecampaign.com/reference#retrieve-a-dealcustomfieldmeta-resource)
 -   [put : Update a custom field](https://developers.activecampaign.com/reference#update-a-dealcustomfieldmeta)
 -   [delete : Delete a custom field](https://developers.activecampaign.com/reference#delete-a-dealcustomfieldmeta-resource)
 -   [get : List all custom fields](https://developers.activecampaign.com/reference#retrieve-all-dealcustomfielddata-resources)
-   [Custom Deal Field Values](https://developers.activecampaign.com/reference#dealcustomfielddata)
 -   [post : Create a custom field value](https://developers.activecampaign.com/reference#create-dealcustomfielddata-resource)
 -   [post : Bulk create a custom field value](https://developers.activecampaign.com/reference#bulk-create-a-custom-field-value)
 -   [get : Retrieve a custom field value](https://developers.activecampaign.com/reference#retrieve-a-dealcustomfielddata)
 -   [put : Update a custom field value](https://developers.activecampaign.com/reference#update-a-dealcustomfielddata-resource)
 -   [patch : Bulk update a custom field value](https://developers.activecampaign.com/reference#bulk-update-a-custom-field-value)
 -   [delete : Delete a custom field value](https://developers.activecampaign.com/reference#retrieve-a-dealcustomfielddata-resource)
 -   [get : List all custom field values](https://developers.activecampaign.com/reference#list-all-custom-field-values)
-   [Secondary Contacts](https://developers.activecampaign.com/reference#secondary-contacts)
 -   [post : Create a secondary contact](https://developers.activecampaign.com/reference#create-a-secondary-contact)
 -   [get : Retrieve a secondary contact](https://developers.activecampaign.com/reference#retrieve-a-secondary-contact)
 -   [put : Update a secondary contact](https://developers.activecampaign.com/reference#update-a-secondary-contact)
 -   [delete : Delete a secondary contact](https://developers.activecampaign.com/reference#delete-a-secondary-contact)
 -   [get : List all secondary contacts](https://developers.activecampaign.com/reference#list-all-secondary-contacts)

### DeepData Integrations

-   [Connections](https://developers.activecampaign.com/reference#connections)
 -   [post : Create a connection](https://developers.activecampaign.com/reference#create-connection)
 -   [get : Retrieve a connection](https://developers.activecampaign.com/reference#get-connection)
 -   [put : Update a connection](https://developers.activecampaign.com/reference#update-connection)
 -   [delete : Delete a connection](https://developers.activecampaign.com/reference#delete-connection)
 -   [get : List all connections](https://developers.activecampaign.com/reference#list-all-connections)
-   [E-Commerce Customers](https://developers.activecampaign.com/reference#customers)
 -   [post : Create a customer](https://developers.activecampaign.com/reference#create-customer)
 -   [get : Retrieve a customer](https://developers.activecampaign.com/reference#get-customer)
 -   [put : Update a customer](https://developers.activecampaign.com/reference#update-customer)
 -   [delete : Delete a customer](https://developers.activecampaign.com/reference#delete-customer)
 -   [get : List all customers](https://developers.activecampaign.com/reference#list-all-customers)
-   [E-Commerce Orders](https://developers.activecampaign.com/reference#orders)
 -   [post : Create an order](https://developers.activecampaign.com/reference#create-order)
 -   [get : Retrieve an order](https://developers.activecampaign.com/reference#get-order)
 -   [delete : Delete an order](https://developers.activecampaign.com/reference#delete-order)
 -   [get : List all orders](https://developers.activecampaign.com/reference#list-all-orders)
 -   [put : Update an order](https://developers.activecampaign.com/reference#update-order)
-   [E-Commerce Abandoned Carts](https://developers.activecampaign.com/reference#e-commerce-abandoned-carts)
-   [E-Commerce Order Products](https://developers.activecampaign.com/reference#e-commerce-order-products)
 -   [get : List EcomOrderProducts](https://developers.activecampaign.com/reference#list-ecomorderproducts)
 -   [get : List EcomOrderProducts for a Specific EcomOrder](https://developers.activecampaign.com/reference#list-products-for-order)
 -   [get : Retrieve an EcomOrderProduct](https://developers.activecampaign.com/reference#retrieve-an-ecomorderproduct)

### Forms

-   [Forms](https://developers.activecampaign.com/reference#forms)
 -   [get : Retrieve a form](https://developers.activecampaign.com/reference#retrieve-forms)
 -   [get : List all forms](https://developers.activecampaign.com/reference#forms-1)

### Lists

-   [Lists](https://developers.activecampaign.com/reference#lists)
 -   [post : Create a list](https://developers.activecampaign.com/reference#create-new-list)
 -   [get : Retrieve a list](https://developers.activecampaign.com/reference#retrieve-a-list)
 -   [delete : Delete a list](https://developers.activecampaign.com/reference#delete-a-list)
 -   [get : Retrieve all lists](https://developers.activecampaign.com/reference#retrieve-all-lists)
 -   [post : Create a list group permission](https://developers.activecampaign.com/reference#create-a-list-group-permission)

### Notes

-   [Notes](https://developers.activecampaign.com/reference#notes)
 -   [post : Create a note](https://developers.activecampaign.com/reference#create-a-note)
 -   [get : Retrieve a note](https://developers.activecampaign.com/reference#retrieve-a-note)
 -   [put : Update a note](https://developers.activecampaign.com/reference#update-a-note)
 -   [delete : Delete a note](https://developers.activecampaign.com/reference#delete-note)

### Organizations (Deprecated)

-   [Organizations](https://developers.activecampaign.com/reference#organizations)
 -   [post : Create an organization](https://developers.activecampaign.com/reference#create-organization)
 -   [get : Retrieve an organization](https://developers.activecampaign.com/reference#get-organization)
 -   [put : Update an organization](https://developers.activecampaign.com/reference#update-organization)
 -   [delete : Delete an organization](https://developers.activecampaign.com/reference#delete-organization)
 -   [delete : Delete multiple organizations](https://developers.activecampaign.com/reference#delete-multiple-organizations)
 -   [get : List all organizations](https://developers.activecampaign.com/reference#list-all-organizations)

### Saved Responses

-   [Saved Responses](https://developers.activecampaign.com/reference#saved-responses-1)
 -   [post : Create a saved response](https://developers.activecampaign.com/reference#saved-responses)
 -   [get : Retrieve a saved response](https://developers.activecampaign.com/reference#get-a-savedresponse)
 -   [put : Update a saved response](https://developers.activecampaign.com/reference#update-a-saved-response)
 -   [delete : Delete a saved response](https://developers.activecampaign.com/reference#retrieve-a-savedresponse)
 -   [get : List all saved responses](https://developers.activecampaign.com/reference#list-all-saved-responses)

### Scores

-   [Scores](https://developers.activecampaign.com/reference#scores)
 -   [get : Retrieve a score](https://developers.activecampaign.com/reference#retrieve-a-score)
 -   [get : List all scores](https://developers.activecampaign.com/reference#list-all-scores)

### Segments

-   [Segments](https://developers.activecampaign.com/reference#segments)
 -   [get : Retrieve a segment](https://developers.activecampaign.com/reference#retrieve-a-segment)
 -   [get : List all segments](https://developers.activecampaign.com/reference#list-all-segments)

### Settings

-   [Settings](https://developers.activecampaign.com/reference#configs)
 -   [put : Update settings](https://developers.activecampaign.com/reference#set-config)

### Site & Event Tracking

-   [Event Tracking](https://developers.activecampaign.com/reference#event-tracking)
 -   [post : Track event](https://developers.activecampaign.com/reference#track-event)
 -   [post : Create a new event (name only)](https://developers.activecampaign.com/reference#create-a-new-event-name-only)
 -   [get : Retrieve status](https://developers.activecampaign.com/reference#retrieve-event-tracking-status)
 -   [put : Enable/disable](https://developers.activecampaign.com/reference#enable-disable-event-tracking)
 -   [delete : Delete event (name only)](https://developers.activecampaign.com/reference#remove-event-name-only)
 -   [get : List all events (names only)](https://developers.activecampaign.com/reference#list-all-event-types)
-   [Site Tracking](https://developers.activecampaign.com/reference#site-tracking)
 -   [post : Add domain to whitelist](https://developers.activecampaign.com/reference#add-domain-to-whitelist)
 -   [get : Retrieve site tracking code](https://developers.activecampaign.com/reference#retrieve-site-tracking-code)
 -   [get : Retrieve status](https://developers.activecampaign.com/reference#retrieve-site-tracking-status)
 -   [put : Enable/disable](https://developers.activecampaign.com/reference#enable-disable-site-tracking)
 -   [delete : Remove domain from whitelist](https://developers.activecampaign.com/reference#remove-domain-from-whitelist)
 -   [get : List all whitelisted domains](https://developers.activecampaign.com/reference#list-all-whitelisted-domains)

### Tags

-   [Tags](https://developers.activecampaign.com/reference#tags)
 -   [post : Create a tag](https://developers.activecampaign.com/reference#create-a-new-tag)
 -   [get : Retrieve a tag](https://developers.activecampaign.com/reference#retrieve-a-tag)
 -   [put : Update a tag](https://developers.activecampaign.com/reference#update-a-tag)
 -   [delete : Delete a tag](https://developers.activecampaign.com/reference#remove-a-tag)
 -   [get : List all tags](https://developers.activecampaign.com/reference#retrieve-all-tags)

### Tasks

-   [Tasks](https://developers.activecampaign.com/reference#tasks)
 -   [post : Create a task](https://developers.activecampaign.com/reference#create-task)
 -   [get : Retrieve a task](https://developers.activecampaign.com/reference#get-task)
 -   [put : Update a task](https://developers.activecampaign.com/reference#update-task)
 -   [delete : Delete a task](https://developers.activecampaign.com/reference#delete-task)
 -   [get : List all tasks](https://developers.activecampaign.com/reference#list-all-tasks)

### Task Types

-   [Task Types](https://developers.activecampaign.com/reference#deal-task-types)
 -   [post : Create a task type](https://developers.activecampaign.com/reference#create-a-deal-task-type)
 -   [get : Retrieve a task type](https://developers.activecampaign.com/reference#retrieve-a-deal-task-type)
 -   [put : Update a task type](https://developers.activecampaign.com/reference#update-a-deal-task-type)
 -   [delete : Delete a task type](https://developers.activecampaign.com/reference#delete-a-deal-task-type)
 -   [get : List all task types](https://developers.activecampaign.com/reference#list-all-deal-task-types)
 -   [put : Move tasks to another task type](https://developers.activecampaign.com/reference#move-deal-tasks-to-another-deal-task-type)

### Templates

-   [Templates](https://developers.activecampaign.com/reference#templates)
 -   [get : Retrieve a template](https://developers.activecampaign.com/reference#retrieve-a-template)

### Users

-   [Users](https://developers.activecampaign.com/reference#users)
 -   [post : Create a user](https://developers.activecampaign.com/reference#create-user)
 -   [get : Retrieve a user](https://developers.activecampaign.com/reference#get-user)
 -   [get : Retrieve a user by email](https://developers.activecampaign.com/reference#get-user-email)
 -   [get : Retrieve a user by username](https://developers.activecampaign.com/reference#get-user-username)
 -   [get : Retrieve logged-in user](https://developers.activecampaign.com/reference#get-user-loggedin)
 -   [put : Update a user](https://developers.activecampaign.com/reference#update-user)
 -   [delete : Delete a user](https://developers.activecampaign.com/reference#delete-user)
 -   [get : List all users](https://developers.activecampaign.com/reference#list-all-users)
-   [Groups](https://developers.activecampaign.com/reference#groups)
 -   [post : Create a group](https://developers.activecampaign.com/reference#create-a-new-group)
 -   [get : Retrieve a group](https://developers.activecampaign.com/reference#retrieve-a-group)
 -   [put : Update a group](https://developers.activecampaign.com/reference#update-a-group)
 -   [delete : Delete a group](https://developers.activecampaign.com/reference#delete-a-group-1)
 -   [get : List all groups](https://developers.activecampaign.com/reference#list-all-groups)

### Webhooks

-   [Webhooks](https://developers.activecampaign.com/reference#webhooks)
 -   [post : Create a webhook](https://developers.activecampaign.com/reference#create-webhook)
 -   [get : Retrieve a webhook](https://developers.activecampaign.com/reference#get-webhook)
 -   [put : Update a webhook](https://developers.activecampaign.com/reference#update-webhook)
 -   [delete : Delete a webhook](https://developers.activecampaign.com/reference#delete-webhook)
 -   [get : List all webhooks](https://developers.activecampaign.com/reference#get-a-list-of-webhooks)
 -   [get : List all webhook events](https://developers.activecampaign.com/reference#get-a-list-of-webhook-events)
-   [Working with webhook data](http://www.activecampaign.com/blog/working-with-webhook-data/)
