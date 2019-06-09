﻿using System;

namespace NTMiner.MinerClient {
    public class MinerEventTypeData : IMinerEventType, IDbEntity<Guid> {
        public MinerEventTypeData() { }

        public Guid GetId() {
            return this.Id;
        }

        [LiteDB.BsonIgnore]
        public DataLevel DataLevel { get; set; }

        public void SetDataLevel(DataLevel dataLevel) {
            this.DataLevel = dataLevel;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
