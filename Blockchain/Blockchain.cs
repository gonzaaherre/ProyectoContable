using System;
using System.Collections.Generic;
using Contabilidad.asiento;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Contabilidad.Blockchain
{
    public class Blockchain
    {
        // Donde se almacena la cadena de bloques
        public IList<Block> Cadena { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public Blockchain()
        {
            InitializeChain();
            AddGenesisBlock();
        }

        // se inicializa la cadena con un bloque vacio
        public void InitializeChain()
        {
            Cadena = new List<Block>();
        }

        public Block CreateGenesisBlock()
        {
            return new Block(DateTime.Now, null, new AsientoContable());
        }

        public void AddGenesisBlock()
        {
            Cadena.Add(CreateGenesisBlock());
        }

        public Block GetLatestBlock()
        {
            return Cadena[Cadena.Count - 1];
        }

        // Metodo para agregar bloque de manera segura calculando los hash
        public void AddBlock(Block block)
        {
            Block latestBlock = GetLatestBlock();
            block.Index = latestBlock.Index + 1;
            block.PreviousHash = latestBlock.Hash;
            block.Hash = block.CalculateHash();
            Cadena.Add(block);
        }
        // Verifica los hash de cada bloque 
        // revisando que no haya sido modificado desde fuera de la aplicación
        public bool IsValid()
        {
            for (int i = 1; i < Cadena.Count; i++)
            {
                Block currentBlock = Cadena[i];
                Block previousBlock = Cadena[i - 1];

                if (currentBlock.Hash != currentBlock.CalculateHash())
                {
                    return false;
                }

                if (currentBlock.PreviousHash != previousBlock.Hash)
                {
                    return false;
                }
            }
            return true;
        }

        public List<AsientoContable> GetBlocksInRange(DateTime fechaInicio, DateTime fechaFin)
        {
            List<AsientoContable> asientosEnRango = new List<AsientoContable>();

            foreach (var bloque in Cadena)
            {
                if (bloque.TimeStamp >= fechaInicio && bloque.TimeStamp <= fechaFin)
                {
                    asientosEnRango.Add(bloque.Data);
                }
            }

            return asientosEnRango;

        }
    }
    }