function editCustomer(id) {
    // Check if id is valid
    if (!id) {
        alert("Invalid customer ID");
        return;
    }


    // Redirect to the Update action in the Customer controller
    window.location.href = '/Customer/Update/' + id;;
}
//function deleteCustomer(id) {
//    if (confirm("Are you sure you want to delete this customer?")) {
//        // Call your API or backend service to delete the customer
//        // Example: Using Fetch API
//        fetch(`/customers/delete/${id}`, {
//            method: 'DELETE',
//        })
//            .then(response => {
//                if (response.ok) {
//                    alert('Customer deleted successfully.');
//                    // Optionally reload the page or remove the row from the table
//                    location.reload();
//                } else {
//                    alert('Failed to delete customer.');
//                }
//            })
//            .catch(error => console.error('Error:', error));
//    }
//}
function deleteCustomer(id) {
    debugger
    if (confirm("Are you sure you want to delete this customer?")) {
        $.ajax({
            url: "/customer/delete?id=" + id,
            type: 'Post',
            success: function (response) {
                alert('Customer deleted successfully.');
                // Optionally reload the page or remove the row from the table
                location.reload();
            },
            error: function (xhr, status, error) {
                alert('Failed to delete customer.');
                console.error('Error:', error);
            }
        });
    }
}
