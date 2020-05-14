function validNumber(n)
{
    let integer

    if ((n^0)===n) {
        integer = true
    } else {
        integer = false
    }
    
    return integer
}
console.log(validNumber (NaN))


function addDays(days) 
{
    let now = new Date()
    now.setDate(now.getDate() + days)

    return now
}
console.log(addDays (5))


function evenFilter(source)
{
    let arr = []

    for (let number of source)
    {
        if (number % 2 === 0) {
            arr.push(number)
        }        
    }

    return arr
}
var source = [-2, -1, 0, 1, 4, 5, 6]
console.log(evenFilter(source))


function cutStrings(source, length)
{
    let arr = []

    for (let str of source)
    {        
        arr.push(str.substr(0, length))
    }

    return arr
}
var source = ['12345678', '123', '123456']
var length = 3
console.log(cutStrings(source, length))


function getFibonachi(length)
{
    let a = 1
    let b = 1
    let arr = [a, b]

    for (let i = 3; i <= length; i++) 
    {
        let c = a + b
        a = b
        b = c
        arr.push(c)
    }

    return arr
}
var length = 15
console.log(getFibonachi(length))


function myDeepCopy(source)
{
    var clone = Object.assign({}, source)
    
    return clone
}
var source = {
    Name: 'Maykl',
    Age: 20,
    SayHello: function() {
        console.log('Hello everybody')
    }
}
console.log(myDeepCopy(source))


function extend(source, bonus)
{
    Object.assign(source, bonus)

    return source
}
var source = {
    Name: 'Michael',
    Surname: 'Yermolenko'
}
var bonus = {
    Age: 20,
    Telegram: '@mixaluch_dp'
}
console.log(extend(source, bonus))


function powBuilder(pow)
{
    function res (n)
    {
        let res = n ** pow
        return res
    }
    return res(n)
}
var n = 2
var pow = 8
console.log(powBuilder(pow))


function firstToUppercase(s)
{
    s = s.charAt(0).toUpperCase() + s.slice(1)
    
    return s
}
var s = 'up'
console.log (firstToUppercase(s))