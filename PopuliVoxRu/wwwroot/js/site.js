$(function () {

    $("#registerModalCenter").validate({
		rules: {
			pName: {
				required: true,
				minlength: 8
			},
			action: "required"
		},
		messages: {
			pName: {
				required: "Please enter some data",
				minlength: "Your data must be at least 8 characters"
			},
			action: "Please provide some data"
		}
	});
});

$(function () {
    $("#loginModalCenter").validate({
		rules: {
			pName: {
				required: true,
				minlength: 8
			},
			action: "required"
		},
		messages: {
			pName: {
				required: "Please enter some data",
				minlength: "Your data must be at least 8 characters"
			},
			action: "Please provide some data"
		}
	});
});

//// add the rule here
//$.validator.addMethod("valueNotEquals", function (value, element, arg) {
//	return arg !== value;
//}, "Value must not equal arg.");

//// configure your validation
//$("form").validate({
//	rules: {
//		SelectName: { valueNotEquals: "default" }
//	},
//	messages: {
//		SelectName: { valueNotEquals: "Please select an item!" }
//	}
//});