using FluentAssertions;

namespace ListifyTest
{
    public class UnitTest1
    {
        [Fact]
        public void If_Index_Is_In_Range_Then_It_Should_Return_Element_At_That_Index()
        {
            //Given a list of numbers ranging from 100 to 200
            var list = new Listify.Listify(100, 200);
            
            //When I access index position 50
            var val = list[50];
            
            //Then I should get back a value of 150
            val.Should().Be(150);
        }

        [Fact]
        public void If_Index_Is_Out_Of_Range_Then_It_Should_Throw_ArgumentOutOfRangeException()
        {
            //Given a list of numbers ranging from 1 to 10
            var list = new Listify.Listify(1, 10);

            //When I access index position 50
            //it should throw ArgumentOutOfRangeException
            var action = () => list[50];
            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("Index out of range (Parameter 'index')");
        }
    }
}