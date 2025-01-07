function editItem(id) {
    // Check if id is valid
    if (!id) {
        alert("Invalid Item ID");
        return;
    }


    // Redirect to the Update action in the Customer controller
    window.location.href = '/Item/Update/' + id;;
}
function deleteItem(id) {
    debugger
    if (confirm("Are you sure you want to delete this Item?")) {
        $.ajax({
            url: "/Item/delete?id=" + id,
            type: 'Post',
            success: function (response) {
                alert('Item deleted successfully.');
                // Optionally reload the page or remove the row from the table
                location.reload();
            },
            error: function (xhr, status, error) {
                alert('Failed to delete Item.');
                console.error('Error:', error);
            }
        });
    }
}
