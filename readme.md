# HttpTrigger - C<span>#</span>

The `HttpTrigger` makes it incredibly easy to have your functions executed via an HTTP call to your function.
This function is designed to be called from MailChimp webhooks

## How it works

When you call the function, be sure you checkout which security rules you apply. If you're using an apikey, you'll need to include that in your request.
The funtion reads form data and then saves it to an Azure Storage Que

## Learn more

<TODO> Documentation
	MailChimp sends data in Post/Form format, which makes it difficult for JSON centric apps such as flow to read. 
	This function solves that problem by taking the form data and sending the fields to an Azure Storage Queue
	