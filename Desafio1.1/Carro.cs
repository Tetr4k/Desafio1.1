using System;

public class Carro
{
	readonly string placa;
	readonly string modelo;
	Motor motor { get => motor;
		set //Ou uma função trocaMotor()?
        {
			if (motor.carro != null) throw new Exception();
			motor.carro = null;
            motor = value;
			motor.carro = this;
		}
	}
	public Carro(string placa, string modelo, Motor motor)
	{
		this.placa = placa;
		this.modelo = modelo;
		this.motor = motor;
	}

	public string VelMax {
		get
        {
            if (motor.cilindrada <= 1.0) return "140 km/h";
            if (motor.cilindrada <= 1.6) return "160 km/h";
            if (motor.cilindrada <= 2.0) return "180 km/h";
            return "200 km/h";
        }
	}
}
