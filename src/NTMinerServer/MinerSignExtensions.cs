﻿using NTMiner.Core.MinerServer;
using NTMiner.User;

namespace NTMiner {
    public static class MinerSignExtensions {
        public static bool IsOwnerBy(this IMinerSign minerSign, IUser user) {
            if (user.IsAdmin()) {
                return true;
            }
            if (string.IsNullOrEmpty(minerSign.OuterUserId)) {
                return false;
            }
            UserId userId = UserId.Create(minerSign.OuterUserId);
            switch (userId.UserIdType) {
                case UserIdType.LoginName:
                    return user.LoginName == userId.Value;
                case UserIdType.Email:
                    return user.Email == userId.Value;
                case UserIdType.Mobile:
                    return user.Mobile == userId.Value;
                default:
                    return false;
            }
        }
    }
}
