import {Ed25519Keypair} from '@mystenspacecy/sui.js';

type Callback<T> = (error: any, result: T | null) => void;

module.exports = {
    generateAddress: (callback: Callback<string>) => {
        const keyPair = new Ed25519Keypair();
        const publicKey = keyPair.getPublicKey();
        callback(null, publicKey.toSuiAddress());
    }
};