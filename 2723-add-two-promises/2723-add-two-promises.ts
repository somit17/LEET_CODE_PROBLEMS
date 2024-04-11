type P = Promise<number>

async function addTwoPromises(promise1: P, promise2: P): P {
    return new Promise (async (res, rej) => {
        promise1.then((val1) => {
            promise2.then((val2) => res(val1 + val2))
        })
    })  
};

/**
 * addTwoPromises(Promise.resolve(2), Promise.resolve(2))
 *   .then(console.log); // 4
 */