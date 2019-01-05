using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCircuitSimulator
{
    using Identifier = UInt16; // identifier of element on circuit
    using Moment = UInt32; // abstract minimal time delta
    using Logic = Boolean; // true - high level signal, false - low level signal
    using PinIndex = Byte; // Index of pin of element
    enum PinSide : Byte { INPUT, OUTPUT }; // Side of pin of element

    interface ICircuit
    {
        // Creates element by type.
        // Returns identifier of created element.
        Identifier AddElement(ElementType type);
        
        // Removes element by id.
        // id Identifier of element to remove.
        void RemoveElement(Identifier id);

        // Returns type of element.
        // id Identifier of element.
        // Returns element type.
        ElementType GetElementType(Identifier id);

        // Restart simulation.
        void RestartSimulation();

        // Continues simulation for one moment.
        void NextMoment();

        // Continues simulation until some moment.
        // moment_number Number of moment until which the simulation will occurs.
        void SimulateUntil(Moment moment_number);

        // Continues simulation for some moments.
        // moments Duration of continuation of simulation.
        void SimulateFor(Moment moments);

        // Sets logic value to terminal.
        // id Identifier of terminal to set.
        // value Setting value.
        void SetTerminalState(Identifier id, Logic value);

        // Returns current state of element.
        // id Identifier of element.
        // Returns current state.
        Logic GetElementState(Identifier id);

        // Returns elements which connected to element.
        // id Identifier of the element to which the elements are connected.
        // side Side of pins of element to get.
        // Returns array of identificators of connected elements.
        Identifier[] GetConnectedElements(Identifier id, PinSide side);

        // Returns number of pins of element.
        // id Identificator of element.
        // side Side of pins.
        // Returns number of pins.
        byte GetNumberOfPins(Identifier id, PinSide side);

        // Sets number of pins of element.
        // id Identificator of element.
        // side Side of pins.
        // n_pins new number of pins.
        void SetNumberOfPins(Identifier id, PinSide side, byte n_pins);

        // Connects element output pin to other element input pin.
        // from_element The element from which the connection will go.
        // to_element The element in which the line will enter.
        // from_pin Pin of from_element from which the connection will go. Must be output.
        // to_pin Pin of to_element in which the line will enter. Must be input.
        void Connect(Identifier from_element, Identifier to_element, PinIndex from_pin, PinIndex to_pin);

        // Disconnects element pin from connected element pin.
        // id Identifier of element to disconnect.
        // pin Index of pin to disconnect.
        void Disconnect(Identifier id, PinIndex pin);

        // Returns delay of element
        // id Identidier of element
        // Returns delay duration in moments
        Moment GetDelay(Identifier id);

        // Sets delay to element
        // id Identifier of element
        // delay New delay of element in moments
        void SetDelay(Identifier id, Moment delay);
    }
}
