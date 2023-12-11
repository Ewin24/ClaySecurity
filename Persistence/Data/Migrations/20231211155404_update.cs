using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb3");

            migrationBuilder.CreateTable(
                name: "categoriapersona",
                columns: table => new
                {
                    idcategoriaPersona = table.Column<int>(type: "int", nullable: false),
                    nombreCategoria = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idcategoriaPersona);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    idestado = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idestado);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    nombrePais = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "tipocontacto",
                columns: table => new
                {
                    idtipoContacto = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idtipoContacto);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "tipodireccion",
                columns: table => new
                {
                    idtipoDireccion = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idtipoDireccion);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "tipopersona",
                columns: table => new
                {
                    idtipoPersona = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idtipoPersona);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "turnos",
                columns: table => new
                {
                    idturnos = table.Column<int>(type: "int", nullable: false),
                    nombreTurno = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    horaTurnoInicio = table.Column<TimeOnly>(type: "time", nullable: true),
                    horaTurnoFin = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idturnos);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    idDepartamento = table.Column<int>(type: "int", nullable: false),
                    nombreDepartamento = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Pais_IdPais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idDepartamento);
                    table.ForeignKey(
                        name: "fk_Departamento_Pais1",
                        column: x => x.Pais_IdPais,
                        principalTable: "pais",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "ciudad",
                columns: table => new
                {
                    idCiudad = table.Column<int>(type: "int", nullable: false),
                    NombreCiudad = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Departamento_idDepartamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idCiudad);
                    table.ForeignKey(
                        name: "fk_Ciudad_Departamento1",
                        column: x => x.Departamento_idDepartamento,
                        principalTable: "departamento",
                        principalColumn: "idDepartamento");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    idPersona = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    fechaRegistro = table.Column<DateOnly>(type: "date", nullable: true),
                    Ciudad_idCiudad = table.Column<int>(type: "int", nullable: false),
                    categoriaPersona_idcategoriaPersona = table.Column<int>(type: "int", nullable: false),
                    tipoPersona_idtipoPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPersona);
                    table.ForeignKey(
                        name: "fk_Persona_Ciudad1",
                        column: x => x.Ciudad_idCiudad,
                        principalTable: "ciudad",
                        principalColumn: "idCiudad");
                    table.ForeignKey(
                        name: "fk_Persona_categoriaPersona1",
                        column: x => x.categoriaPersona_idcategoriaPersona,
                        principalTable: "categoriapersona",
                        principalColumn: "idcategoriaPersona");
                    table.ForeignKey(
                        name: "fk_Persona_tipoPersona1",
                        column: x => x.tipoPersona_idtipoPersona,
                        principalTable: "tipopersona",
                        principalColumn: "idtipoPersona");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "contactopersona",
                columns: table => new
                {
                    idcontactoPersona = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Persona_idPersona = table.Column<int>(type: "int", nullable: false),
                    tipoContacto_idtipoContacto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idcontactoPersona);
                    table.ForeignKey(
                        name: "fk_contactoPersona_Persona1",
                        column: x => x.Persona_idPersona,
                        principalTable: "persona",
                        principalColumn: "idPersona");
                    table.ForeignKey(
                        name: "fk_contactoPersona_tipoContacto1",
                        column: x => x.tipoContacto_idtipoContacto,
                        principalTable: "tipocontacto",
                        principalColumn: "idtipoContacto");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "contrato",
                columns: table => new
                {
                    idcontrato = table.Column<int>(type: "int", nullable: false),
                    fechaContrato = table.Column<DateOnly>(type: "date", nullable: true),
                    fechaFin = table.Column<DateOnly>(type: "date", nullable: true),
                    estado_idestado = table.Column<int>(type: "int", nullable: false),
                    Persona_idCliente = table.Column<int>(type: "int", nullable: false),
                    Persona_idEmpleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idcontrato);
                    table.ForeignKey(
                        name: "fk_contrato_Persona1",
                        column: x => x.Persona_idCliente,
                        principalTable: "persona",
                        principalColumn: "idPersona");
                    table.ForeignKey(
                        name: "fk_contrato_Persona2",
                        column: x => x.Persona_idEmpleado,
                        principalTable: "persona",
                        principalColumn: "idPersona");
                    table.ForeignKey(
                        name: "fk_contrato_estado1",
                        column: x => x.estado_idestado,
                        principalTable: "estado",
                        principalColumn: "idestado");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "direccionpersona",
                columns: table => new
                {
                    iddireccionPersona = table.Column<int>(type: "int", nullable: false),
                    direccion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Persona_idPersona = table.Column<int>(type: "int", nullable: false),
                    tipoDireccion_idtipoDireccion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.iddireccionPersona);
                    table.ForeignKey(
                        name: "fk_direccionPersona_Persona1",
                        column: x => x.Persona_idPersona,
                        principalTable: "persona",
                        principalColumn: "idPersona");
                    table.ForeignKey(
                        name: "fk_direccionPersona_tipoDireccion1",
                        column: x => x.tipoDireccion_idtipoDireccion,
                        principalTable: "tipodireccion",
                        principalColumn: "idtipoDireccion");
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "programacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TurnosIdturnos = table.Column<int>(type: "int", nullable: false),
                    PersonaIdEmpleado = table.Column<int>(type: "int", nullable: false),
                    ContratoIdcontrato = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "programacion_ibfk_1",
                        column: x => x.Id,
                        principalTable: "contrato",
                        principalColumn: "idcontrato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "programacion_ibfk_2",
                        column: x => x.Id,
                        principalTable: "turnos",
                        principalColumn: "idturnos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "programacion_ibfk_3",
                        column: x => x.Id,
                        principalTable: "persona",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateIndex(
                name: "fk_Ciudad_Departamento1_idx",
                table: "ciudad",
                column: "Departamento_idDepartamento");

            migrationBuilder.CreateIndex(
                name: "fk_contactoPersona_Persona1_idx",
                table: "contactopersona",
                column: "Persona_idPersona");

            migrationBuilder.CreateIndex(
                name: "fk_contactoPersona_tipoContacto1_idx",
                table: "contactopersona",
                column: "tipoContacto_idtipoContacto");

            migrationBuilder.CreateIndex(
                name: "fk_contrato_estado1_idx",
                table: "contrato",
                column: "estado_idestado");

            migrationBuilder.CreateIndex(
                name: "fk_contrato_Persona1_idx",
                table: "contrato",
                column: "Persona_idCliente");

            migrationBuilder.CreateIndex(
                name: "fk_contrato_Persona2_idx",
                table: "contrato",
                column: "Persona_idEmpleado");

            migrationBuilder.CreateIndex(
                name: "fk_Departamento_Pais1_idx",
                table: "departamento",
                column: "Pais_IdPais");

            migrationBuilder.CreateIndex(
                name: "fk_direccionPersona_Persona1_idx",
                table: "direccionpersona",
                column: "Persona_idPersona");

            migrationBuilder.CreateIndex(
                name: "fk_direccionPersona_tipoDireccion1_idx",
                table: "direccionpersona",
                column: "tipoDireccion_idtipoDireccion");

            migrationBuilder.CreateIndex(
                name: "fk_Persona_categoriaPersona1_idx",
                table: "persona",
                column: "categoriaPersona_idcategoriaPersona");

            migrationBuilder.CreateIndex(
                name: "fk_Persona_Ciudad1_idx",
                table: "persona",
                column: "Ciudad_idCiudad");

            migrationBuilder.CreateIndex(
                name: "fk_Persona_tipoPersona1_idx",
                table: "persona",
                column: "tipoPersona_idtipoPersona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contactopersona");

            migrationBuilder.DropTable(
                name: "direccionpersona");

            migrationBuilder.DropTable(
                name: "programacion");

            migrationBuilder.DropTable(
                name: "tipocontacto");

            migrationBuilder.DropTable(
                name: "tipodireccion");

            migrationBuilder.DropTable(
                name: "contrato");

            migrationBuilder.DropTable(
                name: "turnos");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "ciudad");

            migrationBuilder.DropTable(
                name: "categoriapersona");

            migrationBuilder.DropTable(
                name: "tipopersona");

            migrationBuilder.DropTable(
                name: "departamento");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
