<h1>Product Selling Company</h1>

<p>We work with a company that sells products. A system is requested from us. <b><i>Product control</i></b> and <b><i>customer control</i></b> are required in this system.</p>

<h1>Requirements</h1>

<ol>
<li>Operations such as <b>registering</b>, <b>deleting records</b>, <b>updating records</b> are required for customers.</li>
<li>Customers are asked to <b> verify </b> when register.</li>
<li>Logging process to the customer <b>database</b> is requested.</li>
<li>We want to see <b> how many products are left </b> after customers receive the product.</li>
<li>We want to associate its products with customers. (I'm talking about which customer bought which product.)</li>
<li>Logging process to the product <b>file</b> is requested.</li>
  </ol>
  
<h1>What Is Our Main Purpose?</h1>

<p> We have to prepare our work based on the layered architecture layout. We should concentrate on code quality and clean code rather than requirements.</p>

<h1>What Have I Done?</h1>

<p>First I determined the assets we need.</p>
<p>Assign variables to entities</p>

+++cs
class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }
    public string NationlityId { get; set; }
}


