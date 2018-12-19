using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovementProcessor.Domain;
using MovementProcessor.Domain.Helper;


namespace MovementProcessor.Interfaces
{
    public interface IDirectionChanger
    {
        Direction GetDirection(Direction direction, Rotation rotation);
    }
}
