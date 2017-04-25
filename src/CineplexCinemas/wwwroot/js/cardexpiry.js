function expiryChecker(){
	
	// Get current month and year
	var date = new Date();
	
	// Get month and year values from the user
	var expiryYear = document.getElementById("expiryYear").value;
	var expiryMonth = document.getElementById("expiryMonth").value;

	// if current year is greater than expiry year, don't submit
	{
		alert("Your credit card is already expired.");
		return false;
	}
	// if expiry year is equal to current year and expiry month is less than current month or greater than 12, don't submit
	{
		alert("Your credit card is already expired.");
		return false;
	}
	// If valid, submit
	else
	{
		return true;
	}
}
