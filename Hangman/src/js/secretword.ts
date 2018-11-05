const axios = require('axios');

export class SecretWord {
    static async getWord(maxWordLength: number, minWordLength: number): Promise<object> {
        var response = await axios.get('http://api.evang.dk/randomwords/', { 'headers': { 'numberOfWords': 1, 'maxWordLength': maxWordLength, 'minWordLength': minWordLength } });
        return response;
    }
}
