namespace Tests;
public class TestInputUtils
{
    [Theory]
    [InlineData("1abc2\r\npqr3stu8vwx\r\na1b2c3d4e5f\r\ntreb7uchet")]
    [InlineData("two1nine\r\neightwothree\r\nabcone2threexyz\r\nxtwone3four\r\n4nineeightseven2\r\nzoneight234\r\n7pqrstsixteen")]
    [InlineData("1abc2\r\npqr3stu8vwx\r\na1b2c3d4e5f\r\ntreb7uchet\r\n")]
    public void NormalizeInput(string input)
    {
        input = InputUtils.NormalizeInput(input);

        Assert.DoesNotContain(input, "\r");
        Assert.False(input.EndsWith("\n"));
    }
}
