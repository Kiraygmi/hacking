


combustionEngine("Z14", 90, 200, 120, 1.6f, "gasoline");
combustionEngine("Irinuca", 10, 200, 120, 10f, "gasoline");


void combustionEngine(string model, int horsePower, int torque, float weight, float volume, string fuelType)
{
    Console.WriteLine("motor cu modelul " + model + " are consum de " + horsePower * volume);
}


combustionEngine(/* model */ "Z14", /* horsePower */ 90, /* torque */ 200, /* weight */ 120, /* volume */ 1.6f, /* fuelType */ "gasoline");
combustionEngine(/* model */ "Irinuca", /* horsePower */ 10, /* torque */ 200, /* weight */ 120, /* volume */ 10f, /* fuelType */ "gasoline");


