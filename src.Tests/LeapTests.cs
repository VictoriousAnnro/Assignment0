namespace src.Tests;

public class LeapTests
{
    [Fact]
    public void Leap_given_4_returns_true()
    {
        // Arrange
        var program = new LeapYear();

         // Act
        var result = program.isLeapYear(4);

        // Assert
        result.Should().Be(true);
    }

    [Fact]
    public void Leap_given_1_returns_false()
    {
        // Arrange
        var program = new LeapYear();

         // Act
        var result = program.isLeapYear(1);

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Leap_given_200_returns_false()
    {
        // Arrange
        var program = new LeapYear();

         // Act
        var result = program.isLeapYear(200);

        // Assert
        result.Should().Be(false);
    }

        [Fact]
    public void Leap_given_400_returns_true()
    {
        // Arrange
        var program = new LeapYear();

         // Act
        var result = program.isLeapYear(400);

        // Assert
        result.Should().Be(true);
    }

}