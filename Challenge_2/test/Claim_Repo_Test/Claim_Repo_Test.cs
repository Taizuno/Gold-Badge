//namespace Claim_Repo_Test;
using Xunit;

public class Claim_Repo_Test
{
    private readonly Claim_Repo _crepo = new Claim_Repo();
    private Claim _claim;
    public Claim_Repo_Test()
    {
        _claim = new Claim();
        Claim_Repo.AddClaim(_claim);
    }
    [Fact]
    public void AddClaim_True()
    {
        var claim = new Claim();
        _crepo.AddClaim(claim);
        int expected = 2;
        int actual = claim.ClaimID;
        
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void ViewAll_True()
    {
        var claim = new Claim();
        var claim1 = new Claim();
        var claim2 = new Claim();
        _crepo.AddClaim(claim);
        _crepo.AddClaim(claim1);
        _crepo.AddClaim(claim2);
        int expected = 4;
        int actual = _crepo.Count();

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void RemoveClaim_True()
    {
        var expected = _crepo.RemoveClaim(_claim);
        Assert.True(expected);
    }
}