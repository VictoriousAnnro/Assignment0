namespace src.Tests;

public class LeapTests
{
    [Fact]
    public void Leap_given_4_returns_false()
    {
        // Arrange
        var program = new LeapYear();

         // Act
        var result = program.isLeapYear(4);

        // Assert
        result.Should().Be(false);
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
    public void Leap_given_400_returns_false()
    {
        // Arrange
        var program = new LeapYear();

         // Act
        var result = program.isLeapYear(400);

        // Assert
        result.Should().Be(false);
    }


        [Fact]
    public void Leap_given_1584_returns_true()
    {
        // Arrange
        var program = new LeapYear();

         // Act
        var result = program.isLeapYear(1584);

        // Assert
        result.Should().Be(true);
    }

            [Fact]
    public void Leap_given_1583_returns_false()
    {
        // Arrange
        var program = new LeapYear();

         // Act
        var result = program.isLeapYear(1583);

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Leap_given_1600_returns_true()
    {
        // Arrange
        var program = new LeapYear();

         // Act
        var result = program.isLeapYear(1600);

        // Assert
        result.Should().Be(true);
    }

        [Fact]
    public void Leap_given_1700_returns_false()
    {
        // Arrange
        var program = new LeapYear();

         // Act
        var result = program.isLeapYear(1700);

        // Assert
        result.Should().Be(false);
    }

}